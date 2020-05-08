using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExpenseLib
{
    public static class Data
    {
        public static Dictionary<int, string> ReadCategory(JObject json, bool income)
        //used for both income and expenses categories, indicated by the boolan value
        {
            Dictionary<int, string> cat = new Dictionary<int, string>();
            List<string> inc = json.SelectToken("category." + (income ? "income" : "expense"))
                .ToObject<List<string>>();
                //determine to get income or expense categories
            for (int i = 0; i < inc.Count; i++)
                cat.Add(i, inc[i]);
                //set id and category name
            return cat;
        }
        public static Dictionary<int, List<Record>[]> Records(JObject json)
        {
            Dictionary<int, List<Record>[]> rec = new Dictionary<int, List<Record>[]>();
            //declare a dictionary. keys are years, values are arrays of 12 lists
            //representing 12 months of every year. the lists hold Record instances
            //which is the records of each months

            List<JProperty> properties = json.Children<JProperty>().ToList();
            //the first element holds the categories
            //remains are entries for every year

            for (int i = 1; i < properties.Count; i++)
            //start from the second element (the first year)
            {
                List<Record>[] records = new List<Record>[12];
                //initialize 12 lists of records for each months

                foreach (JProperty monthRec in properties[i].Values())
                //loop through every object holding the month and records of that month
                    records[Convert.ToInt32(monthRec.Name)]
                        //get the month to determine which list to fill in
                        = JsonConvert.DeserializeObject<List<Record>>(
                            monthRec.Value.ToString());
                            //get records of the month and convert to string

                rec.Add(Convert.ToInt32(properties[i].Name), records);
                    //get the year and convert to integer
            }

            return rec;
        }
    }
}
