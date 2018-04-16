using System;
using System.Text.RegularExpressions;

namespace lab1regex
{
    class lab1regex
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            //foreach (Match m in Regex.Matches(input, pattern))
            //{
            //    Console.Write($"{m.Value} ");
            //}
            //Console.WriteLine($"");

            Regex reg = new Regex(pattern);

            foreach (Match m in reg.Matches(input))
            {
                Console.Write($"{m.Value} ");
            }
            Console.WriteLine($"");
        }
    }
}
