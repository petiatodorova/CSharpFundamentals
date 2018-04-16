using System;
using System.Linq;

namespace _11EqualSums
{
    class EqualSums
    {
        private static int i;

        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool hasMatch = false;
            int theIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (LeftSum(arr, i) == RightSum(arr, i))
                {
                    hasMatch = true;
                    theIndex = i;
                }
            }

            if (hasMatch)
            {
                Console.WriteLine($"{theIndex}");
            }
            else
            {
                Console.WriteLine($"no");
            }
        }

        static int LeftSum(int[] arr, int currIndex)
        {
            int leftSum = 0;
            if (currIndex == 0)
            {
                return 0;
            }
            else
            {
                for (int k = 0; k <= currIndex - 1; k++)
                {
                    leftSum += arr[k];
                }

                return leftSum;
            }
        }

        static int RightSum(int[] arr, int currIndex)
        {
            int rightSum = 0;
            if (currIndex == arr.Length - 1)
            {
                return 0;
            }
            else
            {
                for (int m = currIndex + 1; m <= arr.Length - 1; m++)
                {
                    rightSum += arr[m];
                }

                return rightSum;
            }
        }

    }
}
