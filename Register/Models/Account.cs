using System;

namespace Register.Models
{
    public class Account
    {
        public string CardNumber { get; set; }
        public string PinCode { get; set; } 
        public decimal Balance { get; set; }
        public string OwnerName { get; set; }
        public List<TransactionDetails> Transactions { get; set; } = new List<TransactionDetails>();
        public bool IsBlocked { get; set; } = false; 
    }
}