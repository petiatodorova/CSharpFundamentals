using System;
using System.Collections.Generic;
using System.Linq;

namespace TestDict
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //Console.WriteLine($"{numbers.Contains(5)} + theIndexis: {numbers.IndexOf(5)}");
            List<int> numbers = new List<int>() { 22, 16, 33, 44, 567, 345, 2000, 445, 568 };
            List<int> helpList = new List<int>();


            Console.WriteLine($"Original List2 => {string.Join(" | ", helpList)}");
            Console.WriteLine($"Original List1 => {string.Join(" | ", numbers)}");
            helpList.InsertRange(0, numbers);
            Console.WriteLine($"InsertRange(0, numbers) => {string.Join(" | ", helpList)}");
            PrintStars();

            Console.WriteLine($"Original List => {string.Join(" | ", helpList)}");
            helpList.RemoveAt(3);
            Console.WriteLine($"RemoveAt(3) => {string.Join(" | ", helpList)}");
            PrintStars();

            Console.WriteLine($"Original List => {string.Join(" | ", helpList)}");
            int sum = helpList.Sum();
            Console.WriteLine($"Sum => {sum}");
            PrintStars();

            List<int> takeList = new List<int>();
            Console.WriteLine($"Original List => {string.Join(" | ", helpList)}");
            takeList = helpList.Take(3).ToList();
            Console.WriteLine($"Take(3) => {string.Join(" | ", takeList)}");
            PrintStars();

            Console.WriteLine($"Original List => {string.Join(" | ", helpList)}");
            helpList.Reverse(3, 5);
            Console.WriteLine($"Reverse(3, 5) => {string.Join(" | ", helpList)}");
            PrintStars();

            Console.WriteLine($"Original List => {string.Join(" | ", helpList)}");
            takeList = helpList.Select(x => x * 2).ToList();
            Console.WriteLine($"Select и умножи всеки елемент по 2 => {string.Join(" | ", takeList)}");
            PrintStars();

            
            List<int> listB = new List<int> { 3, 4, 5, 7, 8 };
            List<int> listA = new List<int> { 1, 2, 3, 4, 5 };

            //If you need new list(and exclude the duplicate), you can use Union
            var listFinal = listA.Union(listB);
            Console.WriteLine($"listFinal listA => {string.Join(" | ", listA)}");
            Console.WriteLine($"listFinal listB => {string.Join(" | ", listB)}");
            Console.WriteLine($"listFinal Union\r\n(exclude the duplicates) => {string.Join(" | ", listFinal)}");
            PrintStars();

            //If it is a list, you can also use AddRange method.
            listA.AddRange(listB); // listA now has elements of listB also.
            Console.WriteLine($"listFinal listA => {string.Join(" | ", listA)}");
            Console.WriteLine($"listFinal listB => {string.Join(" | ", listB)}");
            Console.WriteLine($"listA AddRange\r\n(listA now has elements of listB also) => {string.Join(" | ", listA)}");
            PrintStars();

            //If you need new list(and include the duplicate), you can use Concat
            listFinal = listA.Concat(listB);
            Console.WriteLine($"listFinal listA => {string.Join(" | ", listA)}");
            Console.WriteLine($"listFinal listB => {string.Join(" | ", listB)}");
            Console.WriteLine($"listFinal Concat\r\n(and include the duplicates) => {string.Join(" | ", listFinal)}");
            PrintStars();

            //If you need common items, you can use Intersect.
            listB = new List<int> { 3, 4, 5 };
            listA = new List<int> { 1, 2, 3, 4 };
            listFinal = listA.Intersect(listB); //3,4
            Console.WriteLine($"listFinal listA => {string.Join(" | ", listA)}");
            Console.WriteLine($"listFinal listB => {string.Join(" | ", listB)}");
            Console.WriteLine($"listFinal Intersect\r\n(If you need common items) => {string.Join(" | ", listFinal)}");
            PrintStars();


        }

        private static void PrintStars()
        {
            Console.WriteLine($"");
            Console.WriteLine($"{new string('*', 88)}");
            Console.WriteLine($"");
        }
    }
}
