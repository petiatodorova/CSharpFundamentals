using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = @"^([A-Za-z]+)([\||\<|\\])(.*)[\||\<|\\]([A-Za-z]+)";
            Match reg = Regex.Match(keys, pattern);
            string start = reg.Groups[1].Value;
            string end = reg.Groups[4].Value;

            string pattern2 = $@"{start}(.*?){end}";

            MatchCollection myMatches = Regex.Matches(input, pattern2);
            List<string> myPrint = new List<string>();
            foreach (Match match in myMatches)
            {
                myPrint.Add(match.Groups[1].Value);
            }
            string print = $"{string.Join("", myPrint)}";
            if (print == "")
            {
                Console.WriteLine($"Empty result");
            }
            else
            {
                Console.WriteLine($"{print}");
            }
        }
    }
}
