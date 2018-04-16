using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConvertFrom10ToNSystem
{
    class ConvertFrom10ToN
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int system = int.Parse(input[0]);
            BigInteger number = new BigInteger();
            number = BigInteger.Parse(input[1]);
            string result = "";

            BigInteger remainder = 0;
            while (number > 0)
            {
                remainder = number % system;
                number = number / system;
                result = remainder.ToString() + result;
            }

            Console.WriteLine($"{result}");
        }
    }
}
