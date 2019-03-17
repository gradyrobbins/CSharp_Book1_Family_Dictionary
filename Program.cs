using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! family_dictionary");
            Console.WriteLine("");


            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Deacon"},
                {"age", "24"}
            });

            // expected output:
            //  Krista is my sister and is 42 years old
            // hint: Remember that you can use square bracket notation to get to the value of a key, and that a dictionary has a Key and a Value property.
            foreach(KeyValuePair<string, Dictionary<string, string>> kvp in myFamily)
            {
                Console.WriteLine($"  {kvp.Value["name"]} is my {kvp.Key} and is {kvp.Value["age"]} years old");
                Console.WriteLine($"  ");


                    //     foreach (var item in myFamily)
                    // {
                    // Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]} years old");

                    // }
                // foreach(KeyValuePair<Dictionary<string, string>> kvp2 in kvp.Value)
                // Console.WriteLine($"{kvp2.Value}  is {kvp2.Value} years old");
                // Console.WriteLine($"{kvp2.Value} years old");
            }

        }
    }
}
