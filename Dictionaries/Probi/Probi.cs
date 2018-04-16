using System;
using System.Collections.Generic;
using System.Linq;

namespace Probi
{
    class Probi
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, int>> countries = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string country;
            string town;
            int population;

            while (true)
            {
                if (input[0] == "End")
                {
                    break;
                }
                country = input[0];
                town = input[1];
                population = int.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(town, population);
                    countries.Add(country, current);
                }
                else
                {
                    if (!countries[country].ContainsKey(town))
                    {
                        countries[country].Add(town, population);
                    }
                    else
                    {
                        countries[country][town] = population;
                    }
                    
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }
            int sum = 0;
            foreach (var everyCountry in countries.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{everyCountry.Key} => {everyCountry.Value.Values.Sum()}");
                //Console.WriteLine($"{everyCountry.Key} => {everyCountry.Value.Count}");

                foreach (var item in everyCountry.Value.OrderByDescending(z => z.Value))
                {

                    Console.WriteLine($" \t=> {item.Key} => {item.Value}");
                }
            }
        }
    }
}
