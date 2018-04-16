using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] allSentences = Console.ReadLine()
                .Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string pattern = $@"\b{word}\b";
            foreach (var sentence in allSentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine($"{sentence.Trim()}");
                }
            }
        }
    }
}
