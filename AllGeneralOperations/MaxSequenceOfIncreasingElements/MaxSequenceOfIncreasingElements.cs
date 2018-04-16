using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int countMax = 1;
            int countTemp = 1;
            string theMaxSequence = numbers[0].ToString();
            string tempSequence = numbers[0].ToString();

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                while (numbers[i] < numbers[i + 1] && (i + 1 < numbers.Length - 1))
                {
                    countTemp++;
                    tempSequence = tempSequence + ' ' + numbers[i + 1].ToString();
                    i++;
                    if (i == numbers.Length - 2 && numbers[i] < numbers[i + 1])
                    {
                        tempSequence = tempSequence + ' ' + numbers[i + 1].ToString();
                    }
                }

                if (countTemp > countMax)
                {
                    countMax = countTemp;
                    theMaxSequence = tempSequence;
                }
                countTemp = 1;
                tempSequence = numbers[i + 1].ToString();
            }

            Console.WriteLine($"{theMaxSequence}");
        }
    }
}
