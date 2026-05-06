using System;
using System.Collections.Generic;
using System.Text;

namespace Register.Core
{

    public interface IDispenseStrategy
    {
        string Dispense(decimal amount);
    }

    public abstract class BaseDispenseStrategy : IDispenseStrategy
    {
        public abstract string Dispense(decimal amount);

        protected string CalculateBills(decimal amount, int[] denominations)
        {
            decimal remaining = amount;
            var dispensed = new Dictionary<int, int>();

            foreach (int bill in denominations)
            {
                if (remaining >= bill)
                {
                    int count = (int)(remaining / bill);
                    dispensed.Add(bill, count);
                    remaining -= count * bill; 
                }
            }

            if (remaining > 0) return null; 

            var sb = new StringBuilder();
            foreach (var kvp in dispensed)
            {
                sb.AppendLine($"- {kvp.Value} шт. номіналом {kvp.Key} грн");
            }
            return sb.ToString();
        }
    }
    public class DefaultDispenseStrategy : BaseDispenseStrategy
    {
        public override string Dispense(decimal amount)
        {
            int[] bills = { 500, 200, 100, 50 };
            var result = CalculateBills(amount, bills);

            return result != null
                ? "Видано стандартними купюрами:\n" + result
                : "Неможливо видати цю суму (мінімальна купюра 50 грн).";
        }
    }
    public class SmallBillsDispenseStrategy : BaseDispenseStrategy
    {
        public override string Dispense(decimal amount)
        {
            int[] bills = { 100, 50 };
            var result = CalculateBills(amount, bills);

            return result != null
                ? "Видано дрібними купюрами:\n" + result
                : "Неможливо видати суму виключно дрібними купюрами.";
        }
    }
}