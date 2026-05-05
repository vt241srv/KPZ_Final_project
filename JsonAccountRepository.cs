using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using AtmProject.Models;

namespace AtmProject.Data
{
    public class JsonAccountRepository : IAccountRepository
    {
        private readonly string _filePath;

        public JsonAccountRepository(string filePath = "accounts.json")
        {
            _filePath = filePath;
            EnsureFileExists();
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(_filePath))
            {
                SaveAllAccounts(new List<Account>());
            }
        }

        public List<Account> GetAllAccounts()
        {
            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Account>>(json) ?? new List<Account>();
        }

        public void SaveAllAccounts(List<Account> accounts)
        {
          
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(accounts, options);
            File.WriteAllText(_filePath, json);
        }

        public Account GetAccountByCardNumber(string cardNumber)
        {
            return GetAllAccounts().FirstOrDefault(a => a.CardNumber == cardNumber);
        }

        public void UpdateAccount(Account updatedAccount)
        {
            var accounts = GetAllAccounts();
            var index = accounts.FindIndex(a => a.CardNumber == updatedAccount.CardNumber);

            if (index != -1)
            {
                accounts[index] = updatedAccount;
                SaveAllAccounts(accounts);
            }
        }
    }
}