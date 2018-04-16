using System;
using System.Text.RegularExpressions;

namespace ExtractSentencesVariant2
{
    class ExtractSentences2
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = $@"[A-Z][^\.|\!|\?]*\b{word}\b[^\.|\!|\?]*";
            if (Regex.IsMatch(input, pattern))
            {
                MatchCollection myMatches = Regex.Matches(input, pattern);
                foreach (Match match in myMatches)
                {
                    Console.WriteLine($"{match.Value}");
                }
            }
        }
    }
}
