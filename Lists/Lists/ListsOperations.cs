using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class ListsOperations
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5 6 -6 7 5 -6
            //List<int> nums = Console.ReadLine()
            //    .Split(' ')
            //    .Select(int.Parse)
            //    .ToList();

            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, - 6, 7, 5, - 6 };

            //добави в края
            nums.Add(-10);
            Console.WriteLine($"Add: -> {string.Join(" ", nums)}");
            Console.WriteLine($"Count Add: -> ({nums.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //изтрий на позиция 3
            nums.Remove(3);
            Console.WriteLine($"Remove: -> {string.Join(" ", nums)}");
            Console.WriteLine($"Count Remove: -> ({nums.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //добави преди позиция 1, -6
            nums.Insert(1, -6);
            Console.WriteLine($"Insert: -> {string.Join(" ", nums)}");
            Console.WriteLine($"Count Insert: -> ({nums.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //добави преди позиция 3, масив от int-ове
            nums.InsertRange(3, new int[] {-21, -31, -41 });
            Console.WriteLine($"InsertRange: -> {string.Join(" ", nums)}");
            Console.WriteLine($"Count InsertRange: -> ({nums.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //добави в края масив от int-ове
            nums.AddRange(new int[] { -2, -3, -4 });
            Console.WriteLine($"AddRange: -> {string.Join(" ", nums)}");
            Console.WriteLine($"Count AddRange: -> ({nums.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //намира индекса на елемента 5, който съществува в масива
            int index = nums.IndexOf(5);
            Console.WriteLine($"{index}");

            //маха първия
            nums.Remove(-6);
            Console.WriteLine($"Remove: -> {string.Join(" ", nums)}");
            Console.WriteLine($"Count Remove: -> ({nums.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //маха всички -6
            nums.RemoveAll(p => p ==-6);
            Console.WriteLine($"RemoveAll -6: -> {string.Join(" ", nums)}");
            Console.WriteLine($"Count RemoveAll -6: -> ({nums.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //маха всички -6
            nums.RemoveAll(p => p < 2);
            Console.WriteLine($"RemoveAll p < 2: -> {string.Join(" ", nums)}");
            Console.WriteLine($"Count RemoveAll p < 2: -> ({nums.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //избери ми тези, които изпълняват условието и ги сортирай възходящо
            List<int> result = new List<int>();
            result = nums.Where(p => p > 0).OrderBy(p => p).ToList();
            Console.WriteLine($"Where(p => p > 0): -> {string.Join(" ", result)}");
            Console.WriteLine($"Where(p => p > 0): -> ({result.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //за всеки изпълни това
            nums.ForEach(p => Console.WriteLine($"{p / 2}"));
            Console.WriteLine($"nums.ForEach: -> {string.Join(" ", result)}");
            Console.WriteLine($"nums.ForEach: -> ({result.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //вземи ми първите 2
            List<int> result1= new List<int>();
            result1 = nums.Skip(2).Take(6).ToList();
            Console.WriteLine($"nums.Take(2) от който вземаме масив: -> {string.Join(" ", nums)}");
            Console.WriteLine($"nums.Take(2) новия масив: -> {string.Join(" ", result1)}");
            Console.WriteLine($"nums.Take(2): -> ({result1.Count})");
            Console.WriteLine($"* * * * * *");
            Console.WriteLine($"");

            //ако се приложи пак променя масива
            //винаги се прилага лъм масив, който да промени, а не просто така
            result1 = nums.Skip(2).Take(2).ToList();
            Console.WriteLine($"nums.Take(2) новия масив: -> {string.Join(" ", result1)}");
        }
    }
}
