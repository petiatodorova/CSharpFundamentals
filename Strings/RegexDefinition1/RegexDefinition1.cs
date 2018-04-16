using System;
using System.Text.RegularExpressions;

namespace RegexDefinition1
{
    class RegexDefinition1
    {
        public static void Main()
        {
            string pattern = @"(?<day>\d{1,2})-(?<month>\w{3})-(?<year>\d{4})";
            //string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]\b";
            string input = @"22-Jan-2015
						23-Feb-2015
                        2-Jun-2015
                        12-Jul-2015
                        23-Feb-2015
                        2-Jun-2015";


            //първи вариант
            //Regex reg = new Regex(pattern);
            //foreach (Match m in reg.Matches(input))
            //{
            //    Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            //}




            //втори вариант
            //foreach (Match m in Regex.Matches(input, pattern))
            //{
            //    Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            //}



            //трети вариант
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(input);

            foreach (Match m in matches)
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }



            //първото единично съвпадение
            Match singleMatch = reg.Match(input);
            Console.WriteLine($"First Single Match: {singleMatch}");

            if (singleMatch.Success)
            {
                Console.WriteLine($"Number Groups: {singleMatch.Groups.Count}");
                string day = singleMatch.Groups[1].ToString();
                string month = singleMatch.Groups[2].ToString();
                string year = singleMatch.Groups[3].ToString();

                Console.WriteLine($"day: {day}");
                Console.WriteLine($"month: {month}");
                Console.WriteLine($"year: {year}");
            }
        }
    }
}
