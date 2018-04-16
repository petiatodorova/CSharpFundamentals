using System;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string theText = Console.ReadLine();
            foreach (var word in banList)
            {
                if (theText.Contains(word))
                {
                    theText = theText.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine($"{theText}");
        }
    }
}
