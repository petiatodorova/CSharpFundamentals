using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements1
{
    class MaxSequenceOfEqualElements1
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int countMax = 1;
            int countTemp = 1;
            string theMaxSequence = numbers[0].ToString();
            string tempSequence = numbers[0].ToString();

            for (int i = 0; i < numbers.Count - 1; i++)
            {

                while (numbers[i] == numbers[i + 1])
                {
                    countTemp++;
                    tempSequence = tempSequence + ' ' + numbers[i + 1].ToString();
                    
                    if (i == numbers.Count - 2 && numbers[i] == numbers[i + 1])
                    {
                        tempSequence = tempSequence + ' ' + numbers[i + 1].ToString();
                        if (countTemp > countMax)
                        {
                            countMax = countTemp;
                            theMaxSequence = tempSequence;
                        }
                    }
                }

                if (countTemp > countMax)
                {
                    countMax = countTemp;
                    theMaxSequence = tempSequence;
                }
                countTemp = 0;
                tempSequence = numbers[i + 1].ToString();
            }

            Console.WriteLine($"{theMaxSequence}");
        }
    }
}
