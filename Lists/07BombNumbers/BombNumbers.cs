using System;
using System.Collections.Generic;
using System.Linq;

namespace _07BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split(' ')
                  .Select(int.Parse)
                  .ToList();
            int[] bombAndPower = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

            int bombNumber = bombAndPower[0];
            int power = bombAndPower[1];

            while (numbers.Contains(bombNumber))
            {
                int position = numbers.IndexOf(bombNumber);
                if (position - power < 0 && position + power > numbers.Count)
                {
                    numbers.Clear();
                }
                else if (position - power < 0)
                {
                    numbers.RemoveRange(0, position + power + 1);
                }
                else if (position + power > numbers.Count - 1)
                {
                    numbers.RemoveRange(position - power, power + numbers.Count - position);
                }
                else
                {
                    numbers.RemoveRange(position - power, 2 * power + 1);
                }

            }
            Console.WriteLine($"{numbers.Sum()}");
        }
    }
}
