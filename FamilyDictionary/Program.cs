using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a Dictionary that contains information about several members of your family.
            //Use the following example as a template.
            //Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            //myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Jean" }, { "age", "63" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Keith" }, { "age", "59" } });
            myFamily.Add("husband", new Dictionary<string, string>() { { "name", "Phillip" }, { "age", "32" } });
            myFamily.Add("first brother", new Dictionary<string, string>() { { "name", "Braedon" }, { "age", "31" } });
            myFamily.Add("second brother", new Dictionary<string, string>() { { "name", "Nathanael" }, { "age", "29" } });
            myFamily.Add("third brother", new Dictionary<string, string>() { { "name", "Ryan" }, { "age", "27" } });

            //2.Next, iterate over each item in `myFamily` and produce the following output:
            //"Krista is my sister and is 42 years old."

            foreach (var member in myFamily)
            {
                var printString = $"{member.Value["name"]} is my { member.Key } and is {member.Value["age"]} years old.";
                Console.WriteLine(printString);

            }
        }
    }
}
