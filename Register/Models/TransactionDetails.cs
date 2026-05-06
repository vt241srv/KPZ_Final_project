using System;

namespace Register.Models
{
    public class TransactionDetails
    {
        public DateTime Date { get; set; }
        public string Type { get; set; } 
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Date:dd.MM.yyyy HH:mm} | {Type} | {Amount} грн | {Description}";
        }
    }
}