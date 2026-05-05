using System.Collections.Generic;
using Register.Models;

namespace Register.Data
{
    public interface IAccountRepository
    {
        List<Account> GetAllAccounts();
        void SaveAllAccounts(List<Account> accounts);
        Account GetAccountByCardNumber(string cardNumber);
        void UpdateAccount(Account updatedAccount);
    }
}