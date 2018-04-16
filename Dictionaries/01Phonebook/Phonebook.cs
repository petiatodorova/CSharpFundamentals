using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            string name = "";
            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    name = commands[1];

                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = commands[2];
                    }
                    else
                    {
                        phonebook.Add(name, commands[2]);
                    }
                }
                else if (commands[0] == "S")
                {
                    name = commands[1];

                    if (!phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                }
                else if (commands[0] == "ListAll")
                {
                    foreach (var pair in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }

        }
    }
}
