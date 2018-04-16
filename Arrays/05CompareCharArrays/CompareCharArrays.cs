using System;
using System.Linq;

namespace _05CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string[] word1 = Console
                .ReadLine()
                .Split(' ')
                .ToArray();

            string[] word2 = Console
               .ReadLine()
               .Split(' ')
               .ToArray();

            string firstWord = string.Join("", word1);
            string secondWord = string.Join("", word2);

            if (string.CompareOrdinal(firstWord, secondWord) < 0)
            {
                Console.WriteLine($"{firstWord}");
                Console.WriteLine($"{secondWord}");
            }
            else
            {
                Console.WriteLine($"{secondWord}");
                Console.WriteLine($"{firstWord}");
            }
        }
    }
}
