using System;
using System.Collections.Generic;
using System.Linq;

namespace Probi2
{
    class Probi2
    {
        static void Main(string[] args)
        {
            string input = "@fjhgf@";
            string[] proba = input.Split('@').ToArray();
            Console.WriteLine($"{string.Join('|', proba)}");
        }


    }
}
