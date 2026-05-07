using System.IO;
using System.Text.Json;
using Register.Models;

namespace Register.Data
{
    public class JsonAtmVaultRepository
    {
        private readonly string _filePath = "atm_vault.json";

        public AtmVault GetVault()
        {
            if (!File.Exists(_filePath))
            {
                var defaultVault = new AtmVault();
                SaveVault(defaultVault);
                return defaultVault;
            }

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<AtmVault>(json) ?? new AtmVault();
        }

        public void SaveVault(AtmVault vault)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(vault, options);
            File.WriteAllText(_filePath, json);
        }
    }
}