using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] dnaSequence = Console
                .ReadLine()
                .Split('!')
                .Select(int.Parse)
                .ToArray();

            int countMax = 0;
            int countTemp = 1;
            int theMaxNumber = 0;

            for (int i = 0; i < dnaSequence.Length - 1; i++)
            {

                if (dnaSequence[i] == dnaSequence[i + 1])
                {
                    countTemp++;
                }
                else
                {
                    if (countTemp > countMax)
                    {
                        countMax = countTemp;
                        theMaxNumber = dnaSequence[i];
                    }
                    countTemp = 1;
                }
                if (i + 1 == dnaSequence.Length - 1)
                {
                    if (countTemp > countMax)
                    {
                        countMax = countTemp;
                        theMaxNumber = dnaSequence[i];
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
