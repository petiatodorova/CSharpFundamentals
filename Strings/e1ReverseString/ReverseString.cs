using System;
using System.Text;

namespace e1ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            string result = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            Console.WriteLine($"{result}");
            
            
        }
    }
}
