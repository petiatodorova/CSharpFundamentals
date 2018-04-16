using System;
using System.Linq;

namespace _02ReverseAnArrayOfIntegers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrNumbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(arrNumbers);

            Console.WriteLine($"{string.Join(" ", arrNumbers)}");
        }
    }
}
