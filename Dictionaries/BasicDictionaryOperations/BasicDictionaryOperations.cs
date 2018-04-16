using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicDictionaryOperations
{
    class BasicDictionaryOperations
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            phonebook["Наков"] = "089765463";
            phonebook["Пешо"] = "0764 5678";
            phonebook["Наков"] = "нов тел. 078965432";
            phonebook["Ани"] = "089564783";
            phonebook.Add("София", "0935674327");

            //dava bool
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"Печата дали има някакъв Key София");
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"{phonebook.ContainsKey("София")}");
            Console.WriteLine($"");

            //dava bool
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"Печата дали има някаква Value 7");
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"{phonebook.ContainsValue("7")}");
            Console.WriteLine($"");


            //печата OrderBy по Key
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"Печата OrderBy по Key");
            Console.WriteLine($"------------------------------------");

            foreach (var item in phonebook.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine($"");

            
            //печата OrderByDescending по Key
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"Печата OrderByDescending по Key");
            Console.WriteLine($"------------------------------------");

            foreach (var item in phonebook.OrderByDescending(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine($"");


            //печата всички Keys
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"Печата всички Keys");
            Console.WriteLine($"------------------------------------");

            foreach (var key in phonebook.Keys.OrderBy(x => x))
            {
                Console.WriteLine($"{key}");
            }
            Console.WriteLine($"");


            //печата всички Values
            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"Печата всички Values");
            Console.WriteLine($"------------------------------------");

            foreach (var value in phonebook.Values.Select(x => x + "sss"))
            {
                Console.WriteLine($"{value}");
            }
        }
    }
}
