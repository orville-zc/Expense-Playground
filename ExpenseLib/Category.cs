using System.Collections.Generic;

namespace ExpenseLib
{
    public static class Category
    {
        public static Dictionary<int, string> GetExpCat()
        {
            return new Dictionary<int, string>
            {
                { 0, "Food" },
                { 1, "Vegetables" },
                { 2, "Meat" },
                { 3, "Fruits" },
                { 4, "Snacks" },
                { 5, "Restaurant" },
                { 6, "Electronics" },
                { 7, "Social" },
                { 8, "Clothing" },
                { 9, "Health" },
                { 10, "Bills" },
                { 11, "Transportation" },
                { 12, "Entertainment" },
                { 13, "Home" },
                { 14, "Office" },
                { 15, "Other" }
            };
        }
        //default categories with ids for expenses
        public static Dictionary<int, string> getInCat()
        {
            return new Dictionary<int, string>
            {
                { 0, "Investments" },
                { 1, "Salary" },
                { 2, "Gift" },
                { 3, "Awards" },
                { 4, "Other" }
            };
        }
        //default categories with ids for income
    }
}
