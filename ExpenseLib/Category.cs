using System.Collections.Generic;

namespace ExpenseLib
{
    public static class Category
    {
        public static List<string> GetExpCat()
        {
            return new List<string>
            {
                "Food", "Vegetables", "Meat", "Fruits",
                "Snacks", "Restaurant", "Electronics",
                "Social", "Clothing", "Health", "Bills",
                "Transportation", "Entertainment",
                "Home", "Office", "Other"
            };
        }
        //default categories for expenses
        public static List<string> getInCat()
        {
            return new List<string>
            {
                "Investments", "Salary",
                "Gift", "Awards", "Other"
            };
        }
        //default categories for income
    }
}
