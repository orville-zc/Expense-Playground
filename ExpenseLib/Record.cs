using System;

namespace ExpenseLib
{
    public class Record
    {
        public bool Income { get; set; }
        public int Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Memo { get; set; }
    }
}
