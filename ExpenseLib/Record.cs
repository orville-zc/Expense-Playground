using System;

namespace ExpenseLib
{
    public class Record
    {
        public decimal Amount { get; set; }
        public int Category { get; set; }
        public DateTime Date { get; set; }
        public bool Exp { get; set; }
        //true when this record is an expense
        //false for income
        public string Memo { get; set; }

        private void init(decimal amt, int cat, bool exp, string memo)
        {
            Amount = amt;
            Category = cat;
            Memo = memo;
            Exp = exp;
        }
        public Record(decimal amt, int cat, bool exp, string memo)
        {
            init(amt, cat, exp, memo);
            Date = DateTime.Today;
        }
        public Record(decimal amt, int cat, DateTime date, bool exp, string memo)
        {
            init(amt, cat, exp, memo);
            Date = date;
        }
    }
}
