using System;
using System.Linq;

namespace _04LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] countSubs = new int[numbers.Length];
            string[] subsequences = new string[numbers.Length];
            int maxCount = 1;
            int indexOfMaxCount = 0;

            for (int i = 0; i < countSubs.Length; i++)
            {
                countSubs[i] = 1;
                subsequences[i] = numbers[i] + " ";
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        if (1 + countSubs[j] > countSubs[i])
                        {
                            countSubs[i] = 1 + countSubs[j];
                            subsequences[i] = subsequences[j] + numbers[i] + " ";

                            if (countSubs[i] > maxCount)
                            {
                                maxCount = countSubs[i];
                                indexOfMaxCount = i;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"{subsequences[indexOfMaxCount]}");
        }
    }
}
