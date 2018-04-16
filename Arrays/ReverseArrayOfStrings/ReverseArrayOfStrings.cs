using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arrString = Console
                .ReadLine()
                .Split(' ')
                .ToArray();

            Array.Reverse(arrString);

            Console.WriteLine($"{string.Join(" ", arrString)}");
        }
    }
}
