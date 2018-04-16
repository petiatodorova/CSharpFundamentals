using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"\b(?:0x)?[0-9A-F]+\b";
        string input = Console.ReadLine();

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.Write($"{m.Value} ");
        }
    }
}
