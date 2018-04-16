using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tests
{
    class Tests
    {
        static void Main(string[] args)
        {
            string input = "Toshko, Mitko,    ; . Kotyo, Vankata., Mimi.... Didi";

            string[] parts = Regex.Split(input, @"\W+");
            
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine($"{parts[i]}");
            }

            Console.WriteLine($"{char.GetUnicodeCategory("алаБала", 3)}");


            Console.WriteLine($"{string.Join(" | ", parts)}");
        }
    }
}
