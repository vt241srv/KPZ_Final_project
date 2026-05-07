using System;

namespace Register.Models
{
    public class AtmVault
    {
        public int Bills500 { get; set; } = 100;
        public int Bills200 { get; set; } = 100;
        public int Bills100 { get; set; } = 100;
        public int Bills50 { get; set; } = 100;

        public decimal TotalAmount => (Bills500 * 500) + (Bills200 * 200) + (Bills100 * 100) + (Bills50 * 50);
    }
}