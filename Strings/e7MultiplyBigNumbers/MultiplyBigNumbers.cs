using System;
using System.Text;
using System.Linq;

namespace e7MultiplyBigNumbers
{
    class MultiplyBigNumbers
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());
            int remainder = 0;
            int digit = 0;
            int currentResult = 0;

            if (multiplyer == 0)
            {
                Console.WriteLine($"0");
                return;
            }

            StringBuilder result = new StringBuilder();
            
            for (int i = number.Length - 1; i >= 0; i--)
            {
                currentResult = (number[i] - 48) * multiplyer + remainder;
                digit = currentResult % 10;
                remainder = currentResult / 10;
                result.Append(digit);
            }
            if (remainder > 0)
            {
                result.Append(remainder);
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
