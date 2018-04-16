using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraRegex
{
    class Camera
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int elementsToSkip = input[0];
            int elementsToTake = input[1];
            string cameras = Console.ReadLine();
            string pattern = @"(\|<)([\w]{0," + elementsToSkip + @"})([\w]{0," + elementsToTake + @"})";
            MatchCollection matches = Regex.Matches(cameras, pattern);

            List<string> printMatches = new List<string>();
            foreach (Match match in matches)
            {
                printMatches.Add(match.Groups[3].Value);
            }
            Console.WriteLine($"{string.Join(", ", printMatches)}");
        }
    }
}
