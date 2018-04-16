using System;

namespace LastKNumbersSumSequence
{
    class LastKNumbers
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arrSequence = new long[n];

            arrSequence[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int count = 1;
                while (count <= k && i - count >= 0)
                {
                    arrSequence[i] += arrSequence[i - count];
                    count++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arrSequence[i]} ");
            }
        }
    }
}
