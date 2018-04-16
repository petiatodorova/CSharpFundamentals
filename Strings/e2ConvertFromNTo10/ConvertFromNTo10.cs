using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace e2ConvertFromNTo10
{
    class ConvertFromNTo10
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            //3 12201 154
            // 1*3(zero) + 0*3 + 2*3*3

            int baseN = int.Parse(input[0]);
            char[] number = input[1].ToCharArray();

            BigInteger result = new BigInteger();
            result = BigInteger.Parse(number[number.Length - 1].ToString());

            BigInteger basePower = new BigInteger();
            basePower = 1;

            for (int i = number.Length - 2; i >= 0; i--)
            {
                basePower = basePower * baseN;
                result = result + (number[i] - 48) * basePower;
            }

            Console.WriteLine($"{result}");

        }
    }
}
