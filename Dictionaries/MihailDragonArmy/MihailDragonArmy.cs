using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MihailDragonArmy
{
    class MihailDragonArmy
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string name;
            string type;
            int damage = 45;
            int health = 250;
            int armor = 10;
            Dictionary<string, Dictionary<string, List<int>>> dragons = new Dictionary<string, Dictionary<string, List<int>>>();
            string[] input = new string[5];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                name = input[1];
                type = input[0];
                if (input[2] != "null")
                {
                    damage = int.Parse(input[2]);
                }
                if (input[3] != "null")
                {
                    health = int.Parse(input[3]);
                }
                if (input[4] != "null")
                {
                    armor = int.Parse(input[4]);
                }
                List<int> skills = new List<int>() { damage, health, armor };

                if (!dragons.ContainsKey(type))
                {

                    Dictionary<string, List<int>> nameAndSkills = new Dictionary<string, List<int>>();
                    nameAndSkills.Add(name, skills);
                    dragons.Add(type, nameAndSkills);

                }
                else
                {
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, skills);

                    }
                    else
                    {
                        dragons[type][name] = skills;
                    }
                }


                damage = 45;
                health = 250;
                armor = 10;

            }


            foreach (var dragonType in dragons)
            {
                double damageAverage = CalculateAverage(dragonType, 0);
                double healthAverage = CalculateAverage(dragonType, 1);
                double armorAverage = CalculateAverage(dragonType, 2);
                Console.WriteLine($"{dragonType.Key:F2}::({damageAverage:F2}/{healthAverage:F2}/{armorAverage:F2})");
                foreach (var beast in dragonType.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{beast.Key} -> damage: {beast.Value[0]}, health: {beast.Value[1]}, armor: {beast.Value[2]}");
                }
            }


        }

        static double CalculateAverage(KeyValuePair<string, Dictionary<string, List<int>>> dragonType, int position)
        {
            double sum = 0;
            foreach (var currentList in dragonType.Value.Values)
            {

                sum += currentList[position];
            }
            double average = sum / dragonType.Value.Values.Count;
            return average;
        }

    }
}
