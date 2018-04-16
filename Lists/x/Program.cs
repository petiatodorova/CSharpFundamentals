using System;
using System.Linq;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            long[] nums = Console
                .ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long n = nums.Length;
            long kRotations = long.Parse(Console.ReadLine());
            long[] sum = new long[n];
            long[] tempRotated = new long[n];

            if (kRotations == 0)
            {
                Console.WriteLine($"{string.Join(" ", sum)}");
            }
            else
            {
                for (long rotations = 0; rotations < kRotations; rotations++)
                {
                    tempRotated = RotateOnce(n, nums);

                    for (long i = 0; i < n; i++)
                    {
                        sum[i] += tempRotated[i];
                    }
                }

                Console.WriteLine($"{string.Join(" ", sum)}");
            }
        }

        static long[] RotateOnce(long n, long[] arr)
        {
            long temp = arr[n - 1];
            for (long i = n - 1; i >= 1; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = temp;
            return arr;

        }
    }
}
