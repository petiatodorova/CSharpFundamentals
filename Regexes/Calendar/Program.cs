using System;
using System.Text.RegularExpressions;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(?<symbol>[\/|\-|.])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            string input = Console.ReadLine();

            Regex reg = new Regex(pattern);

            foreach (Match m in reg.Matches(input))
            {
                Console.WriteLine($"Day: {m.Groups[1].ToString()}, Month: {m.Groups[3].ToString()}, Year: {m.Groups[4].ToString()}");

            }
        }
    }
}
