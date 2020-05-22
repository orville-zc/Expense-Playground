using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExpenseLib
{
    public static class Data
    {
        public static List<string> ReadCategory(JObject json, bool income)
        //used for both income and expenses categories, indicated by the boolan value
        {
            JToken t = json.SelectToken("category." + (income ? "income" : "expense"));
                                        //determine to get income or expense categories
            return
                (t == null) ? (income ? Category.getInCat() : Category.GetExpCat()) : t.ToObject<List<string>>();
                //if null return the default categories                                 else convert to list
        }

        public static List<string> ReadUnit(JObject json)
        {
            JToken t = json.SelectToken("unit");
            return (t == null) ? Unit.GetUnit() : t.ToObject<List<string>>();
                //if null return default units, else convert to list
        }

        public static decimal ReadTax(JObject json)
        {
            JToken t = json.SelectToken("tax");
            return (t == null) ? 1.13m : t.ToObject<decimal>();
            //if null return default tax rate, else convert to decimal
        }

        public static decimal ReadDisct(JObject json)
        {
            JToken t = json.SelectToken("discount");
            return (t == null) ? 1m : t.ToObject<decimal>();
            //if null return default discount rate, else convert to decimal
        }

        public static Dictionary<string, Dictionary<string, List<Record>>> ReadRecords(JObject json)
        {
            Dictionary<string, Dictionary<string, List<Record>>> rec =
                new Dictionary<string, Dictionary<string, List<Record>>>();
            //declare a dictionary. keys are years, values are also dictionaries
            //whose keys are the month, starting from 0, and values are the lists
            //holding Record instances which are the records of each months

            List<JProperty> properties = json.Children<JProperty>().ToList();
            

            foreach (JProperty p in json.Children<JProperty>())
            //the first elements hold the categories, units
            //remains are entries for every year
            {
                if (!p.Name.All(Char.IsDigit)) continue;
                //bypass the elements for categories, units

                Dictionary<string, List<Record>> records = new Dictionary<string, List<Record>>();
                //initialize lists of records for each months

                foreach (JProperty monthRec in p.Values())
                //loop through every object holding the month and records of that month
                    records.Add(monthRec.Name,
                        //get the month as the key
                        JsonConvert.DeserializeObject<List<Record>>(
                            monthRec.Value.ToString()));
                            //get records of the month and convert to string

                rec.Add(p.Name, records);
                    //get the year and convert to integer
            }

            return rec;
        }

        public static string WriteJson(
            List<string> inCat, //income categories
            List<string> expCat, //expense categories
            Dictionary<string, Dictionary<string, List<Record>>> rec,
            List<string> unitList,
            decimal tax,
            decimal discount) //records
        {
            JObject output = (JObject)JToken.FromObject(
                new Dictionary<string, Dictionary<string, List<string>>>
                {
                    {
                        "category",
                        new Dictionary<string, List<string>>
                        {
                            { "income", inCat },
                            { "expense", expCat }
                        }
                    }
                }
            );

            output.Merge((JObject)JToken.FromObject(
                new Dictionary<string, List<string>>
                {
                    { "unit", unitList }
                }
            ));

            output.Merge((JObject)JToken.FromObject(
                new Dictionary<string, decimal>
                {
                    { "tax", tax },
                    { "discount",  discount}
                }
            ));

            output.Merge((JObject)JToken.FromObject(rec));
            //convert to json and merge as one

            return output.ToString();
        }
    }
}
