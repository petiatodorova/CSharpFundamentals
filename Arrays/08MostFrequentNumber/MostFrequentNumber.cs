using System;
using System.Linq;

namespace _08MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int countMax = 0;
            int countTemp = 0;
            int theMostFrequentNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && (i != j))
                    {
                        countTemp++;
                    }
                   
                }
                if (countTemp > countMax)
                {
                    countMax = countTemp;
                    theMostFrequentNumber = numbers[i];
                }
                countTemp = 0;
            }
            Console.WriteLine($"{theMostFrequentNumber}");
        }
    }
}
