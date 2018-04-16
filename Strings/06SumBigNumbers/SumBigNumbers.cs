using System;
using System.Text;
using System.Linq;

namespace _06SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            int length = 0;
            int currentSumDigits = 0;
            int remainder = 0;
            StringBuilder result = new StringBuilder();
            if (number1.Length >= number2.Length)
            {
                number2 = number2.PadLeft(number1.Length, '0');
                length = number1.Length;
            }
            else
            {
                number1 = number1.PadLeft(number2.Length, '0');
                length = number2.Length;
            }


            for (int i = length - 1; i >= 0; i--)
            {
                currentSumDigits = (number1[i] - 48) + (number2[i] - 48);
                if (currentSumDigits + remainder <= 9)
                {
                    result.Append(currentSumDigits + remainder);
                    remainder = 0;
                }
                else
                {
                    result.Append(currentSumDigits + remainder - 10);
                    remainder = 1;
                }
                if (remainder == 1 && i == 0)
                {
                    result.Append(1);
                }
            }
            StringBuilder theResult = new StringBuilder();
            for (int j = result.Length - 1; j >= 0; j--)
            {
                theResult.Append(result[j]);
            }
            Console.WriteLine($"{theResult.ToString().TrimStart('0')}");
        }
    }
}
