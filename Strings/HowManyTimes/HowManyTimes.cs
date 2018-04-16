using System;

namespace HowManyTimes
{
    class HowManyTimes
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine().ToLower();
            string s2 = Console.ReadLine().ToLower();
            int index = -1;
            int count = 0;
            while (true)
            {
                index = s1.IndexOf(s2, index + 1);
                if (index == -1)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine($"{count}");

        }
    }
}
