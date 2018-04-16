using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            while (commands[0] != "print")
            {
                if (commands[0] == "add")
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);
                    numbers.Insert(index, element);

                }
                else if (commands[0] == "addMany")
                {
                    int index = int.Parse(commands[1]);
                    numbers.InsertRange(index, commands.Skip(2).Select(int.Parse));

                }
                else if (commands[0] == "contains")
                {
                    int theCheckedNumber = int.Parse(commands[1]);
                    if (numbers.Contains(theCheckedNumber))
                    {
                        Console.WriteLine($"{numbers.IndexOf(theCheckedNumber)}");
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (commands[0] == "remove")
                {
                    int index = int.Parse(commands[1]);
                    numbers.RemoveAt(index);

                }
                else if (commands[0] == "shift")
                {
                    int positions = int.Parse(commands[1]) % numbers.Count;
                    var helpList = numbers.Skip(positions).ToList();
                    for (int i = 0; i < positions; i++)
                    {
                        helpList.Add(numbers[i]);
                    }
                    numbers = helpList;
                }
                else if (commands[0] == "sumPairs")
                {
                    int cycles = numbers.Count / 2;
                    for (int i = 0; i < cycles; i++)
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                    }
                }
                commands = Console.ReadLine().Split(' ').ToArray();

            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
