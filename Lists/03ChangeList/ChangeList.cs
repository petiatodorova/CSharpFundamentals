using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    int element = int.Parse(commands[1]);
                    numbers.RemoveAll(p => p == element);
                }
                else if (commands[0] == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, element);
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }
            if (commands[0] == "Odd")
            {
                Console.WriteLine($"{string.Join(" ", numbers.Where(p => p % 2 == 1))}");
            }
            else
            {
                Console.WriteLine($"{string.Join(" ", numbers.Where(p => p % 2 == 0))}");
            }


        }
    }
}
