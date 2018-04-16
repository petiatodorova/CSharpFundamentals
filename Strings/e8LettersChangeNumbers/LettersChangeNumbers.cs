using System;
using System.Text.RegularExpressions;

namespace e8LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] nums = Regex.Split(Console.ReadLine(), @"\b\s+\b");
            char firstChar = '\0';
            char lastChar = '\0';
            string currentNum = "";
            double number = 0;
            double sum = 0;
            double currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentNum = nums[i].Trim().ToString();
                firstChar = currentNum[0];
                lastChar = currentNum[currentNum.Length - 1];
                number = double.Parse(currentNum.Substring(1, currentNum.Length - 2));

                if (Char.IsUpper(firstChar))
                {
                    currentSum = number / (firstChar - 'A' + 1);
                }
                else if (Char.IsLower(firstChar))
                {
                    currentSum = number * (firstChar - 'a' + 1);
                }

                if (Char.IsUpper(lastChar))
                {
                    currentSum = currentSum - (lastChar - 'A' + 1);
                }
                else if (Char.IsLower(lastChar))
                {
                    currentSum = currentSum + (lastChar - 'a' + 1);
                }
                sum += currentSum;
                currentSum = 0;
            }
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
