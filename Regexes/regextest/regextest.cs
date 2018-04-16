using System;
using System.Text.RegularExpressions;

namespace regextest
{
    class regextest
    {
        static void Main(string[] args)
        {
            string input = "alabala -9999 -Azefgjwefg -98768676 gwvdgq$5jhbjhds -04387638";
            string pattern = @"(\-)(\d+)";
            string replaced = Regex.Replace(input, pattern, "$1AA$2");
            Console.WriteLine($"input --> {input}");
            Console.WriteLine($"replaced --> {replaced}");
            PrintStars(66);


            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            

            PrintStars(66);
            Console.WriteLine($"{match.Groups[1].Value}");
            PrintStars(66);
            Console.WriteLine($"input file --> {input}");
            Console.WriteLine($"{input.Replace('9', '*')}");
            int count = 0;
            Console.WriteLine($"regex.Replace(input, new string('*', 5)) => {regex.Replace(input, new string('*', 5))}");
            //направи ми replace на групата от match-ове 
            //по дадения pattern в дадения input стринг 
            foreach (Match m in regex.Matches(input))
            {
                count++;
                Console.WriteLine($"{count} --> {m.Groups[1].Value}");
                Console.WriteLine($"m.Groups[2].Value.Replace('9', '*') --> {m.Groups[2].Value.Replace('9', '*')}");
            }

            Console.WriteLine($"********************************************");
            MatchCollection myMatches = regex.Matches(input);
            Console.WriteLine($"Found {myMatches.Count} matches");

        }

        private static void PrintStars(int n)
        {
            Console.WriteLine($"");
            Console.WriteLine($"{new string('*', n)}");
            Console.WriteLine($"");
        }
    }
}
