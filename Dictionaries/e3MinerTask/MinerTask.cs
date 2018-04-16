using System;
using System.Collections.Generic;

namespace e3MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string material = "";
            int quantity = 0;
            string input = Console.ReadLine();
            while (input != "stop")
            {
                material = input;
                quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(input))
                {
                    resources.Add(material, quantity);
                }
                else
                {
                    resources[material] += quantity;
                }
                input = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }

        }
    }
}
