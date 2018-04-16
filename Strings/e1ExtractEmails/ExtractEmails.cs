using System;
using System.Text.RegularExpressions;

namespace e1ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string pattern = @"\s[a-z0-9]+[.\-_]?[a-z0-9]+[@]{1}[a-z0-9]+[\-]?[a-z0-9]+([.]{1}[a-z0-9]+)+";

            string input = Console.ReadLine();
            RegexOptions options = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                Console.WriteLine("{0}", m.Value.TrimStart());
            }
        }
    }
}
