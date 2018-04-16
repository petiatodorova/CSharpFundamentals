using System;
using System.Linq;

namespace LargestCommonEnd01
{
    class LargestCommonEnd01
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
            int lengthFirst = arrayWords1.Length;
            int lengthSecond = arrayWords2.Length;

            //докато първите елементи са равни
            while (arrayWords1[count] == arrayWords2[count])
            {
                count++;
                if ((count > lengthFirst - 1) || (count > lengthSecond - 1))
                {
                    break;
                }
            }

            if (count > countMax)
            {
                countMax = count;
            }

            //нулираме и проверяваме отзад напред
            count = 0;
            
            while (arrayWords1[lengthFirst - 1 - count] == arrayWords2[lengthSecond - 1 - count])
            {
                count++;
                if ((lengthFirst - 1 - count < 0 ) || (lengthSecond - 1 - count < 0))
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
    }
}
