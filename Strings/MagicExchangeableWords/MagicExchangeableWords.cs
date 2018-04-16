using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Regex.Split(Console.ReadLine(), @"\W+");
            string longerWord = "";
            string shorterWord = "";
            if (input[0].Length >= input[1].Length)
            {
                longerWord = input[0];
                shorterWord = input[1];
            }
            else
            {
                longerWord = input[1];
                shorterWord = input[0];
            }

            Dictionary<string, string> exchangedLetters = new Dictionary<string, string>();
            bool isMagic = true;
            string curCharFromLonger = "";
            string curCharFromShorter = "";

            for (int i = 0; i < shorterWord.Length; i++)
            {
                curCharFromLonger = longerWord[i].ToString();
                curCharFromShorter = shorterWord[i].ToString();

                if (!exchangedLetters.ContainsKey(curCharFromLonger))
                {
                    exchangedLetters.Add(curCharFromLonger, curCharFromShorter);
                }
                else if (exchangedLetters[curCharFromLonger] != curCharFromShorter)
                {
                    isMagic = false;
                }
            }

            for (int j = shorterWord.Length; j < longerWord.Length; j++)
            {
                curCharFromLonger = longerWord[j].ToString();
                if (!exchangedLetters.ContainsKey(curCharFromLonger))
                {
                    isMagic = false;
                }
            }
            if (isMagic)
            {
                Console.WriteLine($"true");
            }
            else
            {
                Console.WriteLine($"false");
            }
        }
    }
}
