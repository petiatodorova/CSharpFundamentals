using System;
using System.Collections.Generic;
using System.Linq;

namespace e7PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            string country = "";
            string city = "";
            long population = 0;

            while (input != "report")
            {
                string[] currentInput = input.Split('|').ToArray();
                country = currentInput[1];
                city = currentInput[0];
                population = long.Parse(currentInput[2]);
                //Sofia|Bulgaria|1000000
                if (!countries.ContainsKey(country))
                {
                    Dictionary<string, long> currentCity = new Dictionary<string, long>();
                    currentCity.Add(city, population);
                    countries.Add(country, currentCity);
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var pair in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");
                foreach (var cityPair in pair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{cityPair.Key}: {cityPair.Value}");
                }
            }
        }
    }
}
