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
            List<string> inc =
                income ? json.SelectToken("category.income").ToObject<List<string>>()
                : json.SelectToken("category.expense").ToObject<List<string>>();
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

            List<JToken> tokens = json.Children().ToList();
            //the first element holds the categories
            //remains are entries for every year

            for (int i = 1; i < tokens.Count; i++)
            //start from the second element (the first year)
            {
                int year = Convert.ToInt32(tokens[i].Path);
                //get the year for the key of dictionary

                List<Record>[] records = new List<Record>[12];
                //initialize 12 lists of records for each months

                foreach (JToken monthRec in tokens[i].Values())
                //loop through every object holding the month and records of that month
                {
                    int month = Convert.ToInt32(monthRec.Path.Substring(5));
                    //get the month to determine which list to fill in
                    //path has the patter of yyyy.Month and the year not needed here

                    records[month] = JsonConvert.DeserializeObject<List<Record>>(
                                        monthRec.Values().ToList()[0].ToString());
                                        //records of the month are kept as an array in json
                                        //Values() returns the collection of that array
                                        //there is only one array in the collection
                                        //use [0] to access it
                    //convert the records to a list of Record
                    //save it to the correct place in the array
                }

                rec.Add(year, records);
            }
            return rec;
        }
    }
}
