using System;
using Register.Data;
using Register.Models;

namespace Register.Core
{
    public class AutomatedTellerMachine
    {
        private readonly IAccountRepository _repository;
        private readonly JsonAtmVaultRepository _vaultRepository; 
        private AtmVault _vault; 

        private Account _currentAccount;

        public delegate void AuthenticationHandler(bool isSuccess, string message);
        public delegate void BalanceCheckHandler(decimal balance);
        public delegate void FundTransferHandler(bool isSuccess, string message);
        public delegate void WithdrawHandler(bool isSuccess, string message);
        public delegate void AdminAuthHandler(bool isSuccess);
        public delegate void VaultUpdatedHandler(AtmVault vault);

        public event AuthenticationHandler OnAuthenticationResult;
        public event BalanceCheckHandler OnBalanceRequested;
        public event FundTransferHandler OnTransferResult;
        public event WithdrawHandler OnWithdrawResult;
        public event AdminAuthHandler OnAdminAuthResult;
        public event VaultUpdatedHandler OnVaultUpdated;

        private IAtmState _currentState;
        private int _failedAttempts = 0;
        private const int MAX_ATTEMPTS = 3;

        public AutomatedTellerMachine(IAccountRepository repository)
        {
            _repository = repository;
            _vaultRepository = new JsonAtmVaultRepository(); 
            _vault = _vaultRepository.GetVault(); 
            _currentState = new IdleState(this);
        }

        public void Authenticate(string cardNumber, string pinCode)
        {
            var account = _repository.GetAccountByCardNumber(cardNumber);
            _currentState.Authenticate(cardNumber, pinCode, account);
        }

        public void Logout()
        {
            _currentAccount = null;
            _failedAttempts = 0;
            SetState(new IdleState(this));
        }
        public void SetState(IAtmState newState)
        {
            _currentState = newState;
        }

        public void SetCurrentAccount(Account account)
        {
            _currentAccount = account;
        }

        public void TriggerAuthResult(bool isSuccess, string message)
        {
            OnAuthenticationResult?.Invoke(isSuccess, message);
        }

        public void AddFailedAttempt(Account account)
        {
            _failedAttempts++;
            if (_failedAttempts >= MAX_ATTEMPTS)
            {
                account.IsBlocked = true;
                _repository.UpdateAccount(account); 
                SetState(new BlockedState(this));
                TriggerAuthResult(false, "Картку заблоковано через 3 невірні спроби!");
            }
            else
            {
                int attemptsLeft = MAX_ATTEMPTS - _failedAttempts;
                TriggerAuthResult(false, $"Невірний PIN-код. Залишилося спроб: {attemptsLeft}");
            }
        }

        public void ResetFailedAttempts()
        {
            _failedAttempts = 0;
        }

        public void RequestBalance()
        {
            if (_currentAccount != null)
            {
                OnBalanceRequested?.Invoke(_currentAccount.Balance);
            }
        }

        public void TransferFunds(string targetCardNumber, decimal amount)
        {
            if (_currentAccount == null) return;

            if (amount <= 0)
            {
                OnTransferResult?.Invoke(false, "Сума переказу має бути більшою за нуль.");
                return;
            }

            if (_currentAccount.Balance < amount)
            {
                OnTransferResult?.Invoke(false, "Недостатньо коштів на рахунку.");
                return;
            }

            var targetAccount = _repository.GetAccountByCardNumber(targetCardNumber);
            if (targetAccount == null)
            {
                OnTransferResult?.Invoke(false, "Картку отримувача не знайдено.");
                return;
            }

            _currentAccount.Balance -= amount;
            targetAccount.Balance += amount;

            _currentAccount.Transactions.Add(new TransactionDetails
            {
                Date = DateTime.Now,
                Type = "Переказ",
                Amount = -amount,
                Description = $"На картку {targetCardNumber}"
            });

            targetAccount.Transactions.Add(new TransactionDetails
            {
                Date = DateTime.Now,
                Type = "Поповнення",
                Amount = amount,
                Description = $"Від {_currentAccount.CardNumber}"
            });

            _repository.UpdateAccount(_currentAccount);
            _repository.UpdateAccount(targetAccount);

            OnTransferResult?.Invoke(true, $"Успішно переказано {amount} грн на картку {targetCardNumber}.");
        }
        public void WithdrawFunds(decimal amount, IDispenseStrategy strategy)
        {
            if (_currentAccount == null) return;

            // 1. Базові перевірки суми та балансу акаунта
            if (amount <= 0 || amount % 50 != 0)
            {
                OnWithdrawResult?.Invoke(false, "Сума має бути кратною 50.");
                return;
            }

            if (_currentAccount.Balance < amount)
            {
                OnWithdrawResult?.Invoke(false, "Недостатньо коштів на вашому рахунку.");
                return;
            }

            var dispenseResult = strategy.Dispense(amount, _vault);

            if (!dispenseResult.IsPossible)
            {
                OnWithdrawResult?.Invoke(false, dispenseResult.Message);
                return;
            }

            foreach (var bill in dispenseResult.Bills)
            {
                switch (bill.Key)
                {
                    case 500: _vault.Bills500 -= bill.Value; break;
                    case 200: _vault.Bills200 -= bill.Value; break;
                    case 100: _vault.Bills100 -= bill.Value; break;
                    case 50: _vault.Bills50 -= bill.Value; break;
                }
            }

            _currentAccount.Balance -= amount;
            _currentAccount.Transactions.Add(new Models.TransactionDetails
            {
                Date = DateTime.Now,
                Type = "Зняття готівки",
                Amount = -amount,
                Description = "Видача через диспенсер"
            });

            _repository.UpdateAccount(_currentAccount);
            _vaultRepository.SaveVault(_vault);

            OnWithdrawResult?.Invoke(true, dispenseResult.Message);
            OnVaultUpdated?.Invoke(_vault);
        }
        public void AuthenticateAdmin(string login, string password)
        {
            if (login == "ADMIN" && password == "8888") 
            {
                OnAdminAuthResult?.Invoke(true);
                OnVaultUpdated?.Invoke(_vault); 
            }
            else
            {
           
                Authenticate(login, password);
            }
        }

        public void ReplenishVault(int add500, int add200, int add100, int add50)
        {
            _vault.Bills500 += add500;
            _vault.Bills200 += add200;
            _vault.Bills100 += add100;
            _vault.Bills50 += add50;

            _vaultRepository.SaveVault(_vault); 
            OnVaultUpdated?.Invoke(_vault);     
        }
    }
}