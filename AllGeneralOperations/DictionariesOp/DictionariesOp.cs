using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesOp
{
    class DictionariesOp
    {
        static void Main(string[] args)
        {
            //country | town <-> population
            Dictionary<string, Dictionary<string, int>> country = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            //пълнене на речника
            while (input[0] != "End")
            {
                string countryName = input[0];
                string town = input[1];
                int population = int.Parse(input[2]);

                if (!country.ContainsKey(countryName))
                //dobavi държавата
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(town, population);
                    country.Add(countryName, current);
                }
                else
                {
                    if (!country[countryName].ContainsKey(town))
                    //добави града
                    {
                        country[countryName].Add(town, population);
                    }
                    else
                    //направи нещо със съществуващите град и държава
                    {
                        country[countryName][town] = population;
                    }
                }

                input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }



            foreach (var kvp in country.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var innerKvp in kvp.Value.OrderBy(y=> y.Value))
                {
                    Console.WriteLine($"{innerKvp.Key} --> {innerKvp.Value}");
                }
            }
        }
    }
}
