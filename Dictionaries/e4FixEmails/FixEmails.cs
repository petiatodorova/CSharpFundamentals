using System;
using System.Collections.Generic;
using System.Linq;

namespace e4FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailsBook = new Dictionary<string, string>();
            string input = Console.ReadLine();
            string name = "";
            string email = "";

            while (input != "stop")
            {
                name = input;
                email = Console.ReadLine();
                if (!emailsBook.ContainsKey(input))
                {
                    emailsBook.Add(name, email);
                }
                else
                {
                    emailsBook[name] = email;
                }
                input = Console.ReadLine();
            }

            foreach (var item in emailsBook)
            {
                if (!item.Value.EndsWith("uk") && !item.Value.EndsWith("us"))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
                
            }
            
            //foreach (var item in emailsBook.Where(x => !x.Value.EndsWith(".uk") && !x.Value.EndsWith(".us")))
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value}");
            //}
        }
    }
}
