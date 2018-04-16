using System;

namespace IsPalindrome
{
    class IsPalindrome
    {
        static void Main(string[] args)
        {
            bool isPalindrome = false;
            string word = Console.ReadLine();
            string reversedWord = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            if (word == reversedWord)
            {
                isPalindrome = true;
            }
            Console.WriteLine($"{isPalindrome}");
        }
    }
}
