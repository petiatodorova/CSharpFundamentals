using System;
using System.Collections.Generic;
using System.Linq;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            n -= 2;
            Console.WriteLine($"{n}");
            //// вкарваме ред от конзолата
            //string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();

            //// правим си Dictionary - за всяка дума колко пъти се среща
            //Dictionary<string, int> count = new Dictionary<string, int>();

            //foreach (var word in input)
            //{
            //    if (!count.ContainsKey(word))
            //    {
            //        count.Add(word, 1);
            //    }
            //    else
            //    {
            //        count[word]++;
            //    }
            //}

            //// зануляваме го
            ////foreach (var word in input)
            ////{
            ////    count[word] = 0;
            ////}

            ////// преброяваме
            ////foreach (var word in input)
            ////{
            ////    count[word]++;
            ////}

            //// печатаме
            //foreach (var item in count)
            //{
            //    Console.WriteLine($"{item.Key} => {item.Value}");
            //}
            ////Console.WriteLine($"{string.Join(" / / ", input)}");

            //// правим си list, за да натъпчем думите, 
            ////които отговарят на определено условие и печатаме
            //List<string> result = new List<string>();
            //foreach (var item in count)
            //{
            //    if (item.Value % 2 == 0)
            //    {
            //        result.Add(item.Key);
            //    }
            //}
            //Console.WriteLine($"{string.Join(" < > ", result)}");
        }
    }
}
