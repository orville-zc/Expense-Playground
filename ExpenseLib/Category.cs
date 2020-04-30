using System.Collections.Generic;

namespace ExpenseLib
{
    public static class Category
    {
        public static Dictionary<int, string> getExpCat()
        {
            Dictionary<int, string> cat = new Dictionary<int, string>();
            cat.Add(0, "Food");
            cat.Add(1, "Vegetables");
            cat.Add(2, "Meat");
            cat.Add(3, "Fruits");
            cat.Add(4, "Snacks");
            cat.Add(5, "Restaurant");
            cat.Add(6, "Electronics");
            cat.Add(7, "Social");
            cat.Add(8, "Clothing");
            cat.Add(9, "Health");
            cat.Add(10, "Bills");
            cat.Add(11, "Transportation");
            cat.Add(12, "Entertainment");
            cat.Add(13, "Home");
            cat.Add(14, "Office");
            cat.Add(15, "Other");
            return cat;
        }
        //default categories for expenses
        public static Dictionary<int, string> getInCat()
        {
            Dictionary<int, string> cat = new Dictionary<int, string>();
            cat.Add(0, "Invesments");
            cat.Add(1, "Salary");
            cat.Add(2, "Gift");
            cat.Add(3, "Awards");
            cat.Add(4, "Other");
            return cat;
        }
        //default categories for income
    }
}
