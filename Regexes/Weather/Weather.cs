using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Weather
{
    class Weather
    {
        static void Main(string[] args)
        {
            
            string pattern = @"(?<town>[A-Z]{2})(?<temperature>[0-9]{2}.[0-9]{1,2})(?<type>[A-Za-z]+)\|";
            string input = "";
            //dictionary town / temperature
            Dictionary<string, double> townTemperature = new Dictionary<string, double>();

            //dictionary town / type
            Dictionary<string, string> townType = new Dictionary<string, string>();

            while (true)
            {
                input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                if (Regex.IsMatch(input,pattern))
                {
                    Match matchLine = Regex.Match(input, pattern);
                    string town = matchLine.Groups["town"].Value;
                    double temperature = double.Parse(matchLine.Groups["temperature"].Value);
                    string type = matchLine.Groups["type"].Value;
                    if (!townTemperature.ContainsKey(town))
                    {
                        townTemperature.Add(town, temperature);
                        townType.Add(town, type);
                    }
                    else
                    {
                        townTemperature[town] = temperature;
                        townType[town] = type;
                    }
                }
            }
            //CA => 22.50 => rainy
            foreach (var town in townTemperature.OrderBy(x => x.Value))
            {
                string theTown = town.Key;
                double theTemperature = townTemperature[theTown];
                string theType = townType[theTown];

                Console.WriteLine($"{theTown} => {theTemperature:F2} => {theType}");
            }
        }
    }
}
