using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] commands = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (nums.Take(commands[0]).Skip(commands[1]).Contains(commands[2]))
            {
                Console.WriteLine($"YES!");
            }
            else
            {
                Console.WriteLine($"NO!");
            }
        }
    }
}
