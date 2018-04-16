using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook2
{
    class Phonebook2
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            while (commands[0] != "END")
            {
                
                string name = commands[1];
                if (commands[0] == "A")
                {
                    if (!phonebook.Keys.Contains(name))
                    {
                        phonebook.Add(name, commands[2]);
                    }
                    else
                    {
                        phonebook[name] = commands[2];
                    }
                }
                else if (commands[0] == "S")
                {
                    if (!phonebook.Keys.Contains(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
