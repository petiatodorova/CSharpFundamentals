using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tests
{
    class Tests
    {
        static void Main(string[] args)
        {
            char symbol = '^';
            int n = 111;
            Console.WriteLine($"1. Задаване и печат на всички match-ове");
            Console.WriteLine($"");
            string input = "alabala  ZZZ9999   ZZZwefg   ZZZ98768676   gwvdgq$5   ZZZ04387638";
            string pattern = @"(ZZZ)(\d+)";
            //matchovete po patterna
            foreach (Match mmm in Regex.Matches(input, pattern))
            {
                Console.WriteLine($"matches are {mmm.Value}");
            }
            PrintStars(symbol,n);




            Console.WriteLine($"2. Replace само на определени думи в input по шаблон pattern");
            Console.WriteLine($"т.е. Replace на input по pattern с текст, в който си остават групите от pattern");
            Console.WriteLine($"");
            //string replacement съдържа група 1 и група 2 от pattern-a
            //вкарани са като $1 и $2 там, където искаме да бъдат заменени
            string replacement = @"<>$1<><><>$2<>";
            //замени ми в input по горния pattern с replacement стринга,
            //в който на някакви места слагаме групи $1 и $2
            string replaced = Regex.Replace(input, pattern, replacement);
            Console.WriteLine($"input --> {input}");
            Console.WriteLine($"pattern --> {pattern}");
            Console.WriteLine($"replacement --> {replacement}");
            Console.WriteLine($"replaced --> {replaced}");
            PrintStars(symbol, n);

            Console.WriteLine($"3. Замени ми всички намерени matches ");
            Console.WriteLine($"отпечатай ги и им смени всяко '9' със '*'");
            Console.WriteLine($"");
            Regex regex = new Regex(pattern);
            int count = 0;
            Console.WriteLine($"regex.Replace(input, new string('*', 5)) => {regex.Replace(input, new string('*', 5))}");
            //направи ми replace на групата от match-ове 
            //по дадения pattern в дадения input стринг 
            foreach (Match m in regex.Matches(input))
            {
                count++;
                Console.Write($"{count} --> {m.Groups[2].Value}     ");
                Console.WriteLine($"m.Groups[2].Value.Replace('9', '*') --> {m.Groups[2].Value.Replace('9', '*')}");
            }

            PrintStars(symbol, n);

            Console.WriteLine($"4. Колко match-a намери?");
            Console.WriteLine($"");
            MatchCollection myMatches = regex.Matches(input);
            Console.WriteLine($"Found {myMatches.Count} matches");

        }

        private static void PrintStars(char symbol, int n)
        {
            Console.WriteLine($"");
            Console.WriteLine($"{new string(symbol, n)}");
            Console.WriteLine($"");
        }
    }
}
