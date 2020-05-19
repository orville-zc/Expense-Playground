using System;
using Newtonsoft.Json;

namespace ExpenseLib
{
    public class Record
    {
        private static int count = 0;
        private int id;
        public decimal Amount { get; set; }
        public int Category { get; set; }
        public DateTime Date { get; set; }
        public bool Exp { get; set; }
        //true when this record is an expense
        //false for income
        public string Memo { get; set; }
        public double Qty { get; set; }
        public int Unit { get; set; }

        [JsonConstructor] //when reading from json, use this constructor
        public Record(decimal amount, int? category, DateTime? date, bool? exp, string memo, double? qty, int? unit)
        {
            if (amount <= 0m) throw new ArgumentException("The amount should be positive.");
            if (unit != null && qty == null)
                throw new ArgumentException("It's meaningless to store the unit without the quantity.", "qty");
            Amount = amount;
            Category = (category == null) ? -1 : (int)category;
            Memo = memo;
            Exp = (exp == null) ? true : (bool)exp;
            Qty = (qty > 0.0) ? (double)qty : 0.0;
            Unit = (unit == null) ? -1 : (int)unit;
            Date = (date == null) ? DateTime.Today : (DateTime)date;
            id = count;
            count++;
        }

        public int GetId()
        {
            return id;
        }
    }
}
