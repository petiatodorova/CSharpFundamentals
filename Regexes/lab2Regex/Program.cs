using System;
using System.Text.RegularExpressions;

namespace lab2Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ | -])2(\1)[\d]{3}(\1)[\d]{4}\b";
            string input = Console.ReadLine();

            Regex reg = new Regex(pattern);

            foreach (Match m in reg.Matches(input))
            {
                Console.Write($"{m.Value}, ");
            }
            Console.WriteLine($"");
        }
    }
}
