using System;
using System.Linq;

namespace _04TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool hasMatch = false;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = 0; b < numbers.Length; b++)
                {
                    for (int c = 0; c < numbers.Length; c++)
                    {
                        if ((0 <= a) && (a < b) && (b < numbers.Length) && (numbers[a] + numbers[b] == numbers[c]) && (c != a) && (c != b))
                        {
                            hasMatch = true;
                            Console.WriteLine($"{numbers[a]} + {numbers[b]} == {numbers[c]}");
                        }
                    }
                }
            }


            if (!hasMatch)
            {
                Console.WriteLine($"No");
            }
        }
    }
}
