using System;

namespace e3UnicodeCharacters
{
    class Unicode
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var symbol in input)
            {
                Console.Write($"\\u{(int)symbol:x4}");
            }
        }
    }
}
