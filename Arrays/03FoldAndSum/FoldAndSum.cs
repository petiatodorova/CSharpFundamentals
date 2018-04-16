using System;
using System.Linq;

namespace _03FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int temp = numbers.Length / 4;
            int[] sums = new int[2 * temp];

            for (int i = 0; i < temp; i++)
            {
                //смята от 0 до (temp - 1)
                sums[i] = numbers[temp + i] + numbers[temp - 1 - i];

                //смята от temp до (2 * temp - 1)
                sums[i + temp] = numbers[2 * temp + i] + numbers[4 * temp - 1 - i];
            }

            Console.WriteLine($"{string.Join(" ", sums)}");
        }
    }
}
