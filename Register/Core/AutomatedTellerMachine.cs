using System;
using Register.Data;
using Register.Models;

namespace Register.Core
{
    public class AutomatedTellerMachine
    {
        private readonly IAccountRepository _repository;
        private Account _currentAccount;

        public delegate void AuthenticationHandler(bool isSuccess, string message);
        public delegate void BalanceCheckHandler(decimal balance);
        public delegate void FundTransferHandler(bool isSuccess, string message);

        public event AuthenticationHandler OnAuthenticationResult;
        public event BalanceCheckHandler OnBalanceRequested;
        public event FundTransferHandler OnTransferResult;

        public AutomatedTellerMachine(IAccountRepository repository)
        {
            _repository = repository;
        }

        public void Authenticate(string cardNumber, string pinCode)
        {
            var account = _repository.GetAccountByCardNumber(cardNumber);

            if (account != null && account.PinCode == pinCode)
            {
                _currentAccount = account;
                OnAuthenticationResult?.Invoke(true, $"Вітаємо, {account.OwnerName}!");
            }
            else
            {
                OnAuthenticationResult?.Invoke(false, "Невірний номер картки або PIN-код.");
            }
        }

        public void Logout()
        {
            _currentAccount = null;
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

            _repository.UpdateAccount(_currentAccount);
            _repository.UpdateAccount(targetAccount);

            OnTransferResult?.Invoke(true, $"Успішно переказано {amount} грн на картку {targetCardNumber}.");
        }
    }
}