using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesGeneral
{
    class DictionariesGeneral
    {
        private static object pair;

        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            phonebook["John Smith"] = "+1-555-8976";
            phonebook["Lisa Smith"] = "+1-555-1234";
            phonebook["Sam Doe"] = "+1-555-5030";
            phonebook["Nakov"] = "+359-899-555-592";
            phonebook["Nakov"] = "+359-2-981-9819"; // Replace
            phonebook.Remove("John Smith");

            foreach (var pair in phonebook)
                Console.WriteLine("{0} --> {1}",
                pair.Key, pair.Value);

            foreach (var phone in phonebook)
            {
                Console.WriteLine($"{phone.Key} --> {phone.Value}");

            }

        }
    }
}
