using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming1
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> recourcesPrimary = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            int currentQuantity;
            string currentMaterial;
            recourcesPrimary.Add("shards", 0);
            recourcesPrimary.Add("fragments", 0);
            recourcesPrimary.Add("motes", 0);
            bool prizeObtained = false;
            string prize = "";

            while (!prizeObtained)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                for (int i = 0; i < input.Length; i += 2)
                {
                    currentQuantity = int.Parse(input[i]);
                    currentMaterial = input[i + 1].ToLower();
                    if (recourcesPrimary.ContainsKey(currentMaterial))
                    {
                        recourcesPrimary[currentMaterial] += currentQuantity;
                    }
                    else if (!junk.ContainsKey(currentMaterial))
                    {
                        junk.Add(currentMaterial, currentQuantity);
                    }
                    else
                    {
                        junk[currentMaterial] += currentQuantity;
                    }

                    if (recourcesPrimary["shards"] >= 250)
                    {
                        prize = "Shadowmourne";
                        prizeObtained = true;
                        recourcesPrimary["shards"] -= 250;
                        break;
                    }
                    if (recourcesPrimary["fragments"] >= 250)
                    {
                        prize = "Valanyr";
                        prizeObtained = true;
                        recourcesPrimary["fragments"] -= 250;
                        break;
                    }
                    if (recourcesPrimary["motes"] >= 250)
                    {
                        prize = "Dragonwrath";
                        prizeObtained = true;
                        recourcesPrimary["motes"] -= 250;
                        break;
                    }
                }
            }
            Console.WriteLine($"{prize} obtained!");
            foreach (var item in recourcesPrimary.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var itemJunk in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{itemJunk.Key}: {itemJunk.Value}");
            }
        }
    }
}
