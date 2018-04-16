using System;
using System.Linq;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = nums.Length;
            int kRotations = int.Parse(Console.ReadLine());
            int[] sum = new int[n];

            for (int rotations = 0; rotations < kRotations; rotations++)
            {
                nums = RotateOnce(nums);
                for (int m = 0; m < n; m++)
                {
                    sum[m] += nums[m];
                }
            }

            Console.WriteLine($"{string.Join(" ", sum)}");
        }

        static int[] RotateOnce(int[] nums)
        {
            int[] tempRotated = new int[nums.Length];
            int last = nums[nums.Length - 1];
            for (int i = 1; i < tempRotated.Length; i++)
            {
                tempRotated[i] = nums[i - 1];
            }
            tempRotated[0] = last;
            return tempRotated;
        }
    }
}
