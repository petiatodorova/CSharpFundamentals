using System;
using System.Collections.Generic;
using System.Linq;

namespace _01MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int countMax = 0;
            int countTemp = 1;
            int theMaxNumber = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    countTemp++;
                }
                else
                {
                    if (countTemp > countMax)
                    {
                        countMax = countTemp;
                        theMaxNumber = numbers[i];
                    }
                    countTemp = 1;
                }
                if (i + 1 == numbers.Count - 1)
                {
                    if (countTemp > countMax)
                    {
                        countMax = countTemp;
                        theMaxNumber = numbers[i];
                    }
                }

            }
            for (int i = 0; i < countMax; i++)
            {
                Console.Write($"{theMaxNumber} ");
            }
        }
    }
}
