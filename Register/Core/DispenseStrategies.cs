using System;
using System.Collections.Generic;
using System.Text;

namespace Register.Core
{

    public interface IDispenseStrategy
    {
        DispenseResult Dispense(decimal amount, Models.AtmVault vault);
    }

    public class DispenseResult
    {
        public bool IsPossible { get; set; }
        public string Message { get; set; }
        public Dictionary<int, int> Bills { get; set; } = new Dictionary<int, int>();
    }

    public abstract class BaseDispenseStrategy : IDispenseStrategy
    {
        public abstract DispenseResult Dispense(decimal amount, Models.AtmVault vault);

        protected DispenseResult CalculateWithVaultCheck(decimal amount, int[] denominations, Models.AtmVault vault)
        {
            decimal remaining = amount;
            var result = new DispenseResult();

            var vaultBills = new Dictionary<int, int> {
                { 500, vault.Bills500 }, { 200, vault.Bills200 },
                { 100, vault.Bills100 }, { 50, vault.Bills50 }
            };

            foreach (int bill in denominations)
            {
                if (remaining >= bill)
                {
                    int countNeeded = (int)(remaining / bill);
                    int actualCount = Math.Min(countNeeded, vaultBills[bill]);

                    if (actualCount > 0)
                    {
                        result.Bills.Add(bill, actualCount);
                        remaining -= actualCount * bill;
                    }
                }
            }

            if (remaining > 0)
            {
                result.IsPossible = false;
                result.Message = "У банкоматі недостатньо потрібних купюр для видачі цієї суми.";
                return result;
            }

            result.IsPossible = true;
            var sb = new StringBuilder();
            foreach (var kvp in result.Bills) sb.AppendLine($"- {kvp.Value} шт. по {kvp.Key} грн");
            result.Message = sb.ToString();

            return result;
        }
    }
    public class DefaultDispenseStrategy : BaseDispenseStrategy
    {
        public override DispenseResult Dispense(decimal amount, Models.AtmVault vault)
        {
            int[] bills = { 500, 200, 100, 50 };
            var result = CalculateWithVaultCheck(amount, bills, vault);

            if (result.IsPossible)
            {
                result.Message = "Видано стандартними купюрами:\n" + result.Message;
            }
            return result;
        }
    }
    public class SmallBillsDispenseStrategy : BaseDispenseStrategy
    {
        public override DispenseResult Dispense(decimal amount, Models.AtmVault vault)
        {
            int[] bills = { 100, 50 };
            var result = CalculateWithVaultCheck(amount, bills, vault);

            if (result.IsPossible)
            {
                result.Message = "Видано дрібними купюрами:\n" + result.Message;
            }
            return result;
        }
    }
}