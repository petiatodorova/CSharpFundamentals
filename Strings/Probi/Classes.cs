using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Probi
{
    class Classes
    {
        static void Main(string[] args)
        {

            List<Book> myBooks = new List<Book>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book();
                book.Author = input[0];
                book.Title = input[1];
                myBooks.Add(book);
            }

            foreach (var author in myBooks)
            {
                Console.WriteLine($"{author.Author} -> {author.Title}");
            }

        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

    }
}
