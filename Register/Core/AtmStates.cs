using System;
using Register.Models;

namespace Register.Core
{
    public interface IAtmState
    {
        void Authenticate(string cardNumber, string pinCode, Account account);
        void PerformOperation();
    }

    public class IdleState : IAtmState
    {
        private readonly AutomatedTellerMachine _atm;

        public IdleState(AutomatedTellerMachine atm)
        {
            _atm = atm;
        }

        public void Authenticate(string cardNumber, string pinCode, Account account)
        {
            if (account == null)
            {
                _atm.TriggerAuthResult(false, "Картку не знайдено.");
                return;
            }

            if (account.IsBlocked)
            {
                _atm.SetState(new BlockedState(_atm));
                _atm.TriggerAuthResult(false, "Ваша картка заблокована! Зверніться до банку.");
                return;
            }

            if (account.PinCode == pinCode)
            {
                _atm.ResetFailedAttempts();
                _atm.SetCurrentAccount(account);
                _atm.SetState(new AuthenticatedState(_atm));
                _atm.TriggerAuthResult(true, $"Вітаємо, {account.OwnerName}!");
            }
            else
            {
                _atm.AddFailedAttempt(account);
            }
        }

        public void PerformOperation()
        {
            throw new InvalidOperationException("Спочатку увійдіть в систему.");
        }
    }

    public class AuthenticatedState : IAtmState
    {
        private readonly AutomatedTellerMachine _atm;

        public AuthenticatedState(AutomatedTellerMachine atm)
        {
            _atm = atm;
        }

        public void Authenticate(string cardNumber, string pinCode, Account account)
        {
            _atm.TriggerAuthResult(false, "Ви вже увійшли в систему.");
        }

        public void PerformOperation()
        {
           
        }
    }

    public class BlockedState : IAtmState
    {
        private readonly AutomatedTellerMachine _atm;

        public BlockedState(AutomatedTellerMachine atm)
        {
            _atm = atm;
        }

        public void Authenticate(string cardNumber, string pinCode, Account account)
        {
            _atm.TriggerAuthResult(false, "Банкомат заблокував цю картку з міркувань безпеки.");
        }

        public void PerformOperation()
        {
            throw new InvalidOperationException("Картка заблокована.");
        }
    }
}