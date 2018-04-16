using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromeWords
{
    class PalindromeWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ', '?', '!', '.', ':', ';'  }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromeWords = new List<string>();

            foreach (var word in input)
            {
                if (IsPalindrome(word))
                {
                    palindromeWords.Add(word);
                }
                
            }
            List<string> test = new List<string>;
            test = palindromeWords.Distinct().OrderBy(x => x));
            Console.WriteLine($"{string.Join(", ", palindromeWords.Distinct().OrderBy(x => x))}");

        }

        static bool IsPalindrome(string theWord)
        {
            bool isPalindrome = false;
            string word = theWord;
            string reversedWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            if (word == reversedWord)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
