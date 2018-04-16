using System;
using System.Linq;

namespace e4CharacterMultiplyer
{
    class CharacterMultiplyer
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string str1 = input[0];
            string str2 = input[1];
            int sum = 0;

            if (str1.Length >= str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    sum += (int)str1[i] * (int)str2[i];
                }
                for (int j = str2.Length; j < str1.Length; j++)
                {
                    sum += (int)str1[j];
                }

            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += (int)str1[i] * (int)str2[i];
                }
                for (int j = str1.Length; j < str2.Length; j++)
                {
                    sum += (int)str2[j];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
