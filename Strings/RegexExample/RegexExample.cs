using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"(\w+)\:\/\/([a-z0-9.\-_]+)";
        string input = @"https://judge.soft_uni.bg/
https://soft-uni.bg/
http://www.nakov.com/research/";

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}
