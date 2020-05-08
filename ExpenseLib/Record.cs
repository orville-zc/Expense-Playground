using System;
using Newtonsoft.Json;

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

        private void Init(decimal amt, int cat, bool exp, string memo)
        {
            Amount = amt;
            Category = cat;
            Memo = memo;
            Exp = exp;
        }
        public Record(decimal amt, int cat, bool exp, string memo)
        {
            Init(amt, cat, exp, memo);
            Date = DateTime.Today;
        }

        [JsonConstructor] //when reading from json, use this constructor
        public Record(decimal amt, int cat, DateTime date, bool exp, string memo)
        {
            Init(amt, cat, exp, memo);
            Date = date;
        }
    }
}
