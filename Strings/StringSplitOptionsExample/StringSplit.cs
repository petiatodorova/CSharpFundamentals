using System;

namespace StringSplitOptionsExample
{
    class StringSplit
    {
        static void Main(string[] args)
        {
            string tags = "One, Two, , Three,   Foo Bar, , Day    , ";

            string[] tagsSplit = tags.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"{string.Join('|', tagsSplit)}");


        }
    }
}
