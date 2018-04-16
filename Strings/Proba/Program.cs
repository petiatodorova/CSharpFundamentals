using System;
using System.Collections.Generic;
using System.Linq;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = 't';
            int number = 4;
            char proba = GivesChar(firstChar, number);
            Console.WriteLine($"{proba}");
            //Console.WriteLine($"{(firstChar - 4)}");
            //Console.WriteLine($"{Convert.ToChar(firstChar - 4)}");
            

        }
        static char GivesChar(char character, int number)
        {
            char curChar = character;
            return Convert.ToChar(curChar - number);
            //Console.WriteLine($"{(curChar - 4)}");
            //Console.WriteLine($"{Convert.ToChar(curChar - 4)}");
        }
    }
}
