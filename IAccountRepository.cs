using System.Collections.Generic;
using AtmProject.Models;

namespace AtmProject.Data
{
    public interface IAccountRepository
    {
        List<Account> GetAllAccounts();
        void SaveAllAccounts(List<Account> accounts);
        Account GetAccountByCardNumber(string cardNumber);
        void UpdateAccount(Account updatedAccount);
    }
}