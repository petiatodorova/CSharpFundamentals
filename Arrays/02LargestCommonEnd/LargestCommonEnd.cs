using System;
using System.Linq;

namespace _02LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] arrayWords1 = Console
                .ReadLine()
                .Split(' ')
                .ToArray();

            string[] arrayWords2 = Console
                .ReadLine()
                .Split(' ')
                .ToArray();

            int count = 0;
            int countMax = 0;
            string[] tempWord1, tempWord2;
            MakesArraysCopies(arrayWords1, arrayWords2, out tempWord1, out tempWord2);

            while (tempWord1.First().SequenceEqual(tempWord2.First()))
            {
                count++;
                if (tempWord1.Length > 1 && tempWord2.Length > 1)
                {
                    tempWord1 = tempWord1.Skip(1).ToArray();
                    tempWord2 = tempWord2.Skip(1).ToArray();
                }
                else
                {
                    break;
                }
 
            }
            if (count > countMax)
            {
                countMax = count;
            }

            MakesArraysCopies(arrayWords1, arrayWords2, out tempWord1, out tempWord2);

            count = 0;
            while (tempWord1.Last().SequenceEqual(tempWord2.Last()))
            {
                count++;

                if (tempWord1.Length > 1 && tempWord2.Length > 1)
                {
                    Array.Resize(ref tempWord1, (tempWord1.Length - 1));
                    Array.Resize(ref tempWord2, (tempWord2.Length - 1));
                }
                else
                {
                    break;
                }

            }
            if (count > countMax)
            {
                countMax = count;
            }

            Console.WriteLine($"{countMax}");

        }

        static void MakesArraysCopies(string[] arrayWords1, string[] arrayWords2, out string[] temp1, out string[] temp2)
        {
            temp1 = new string[arrayWords1.Length];
            temp2 = new string[arrayWords2.Length];
            arrayWords1.CopyTo(temp1, 0);
            arrayWords2.CopyTo(temp2, 0);
        }
    }
}
