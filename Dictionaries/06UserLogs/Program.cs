using System;
using System.Collections.Generic;

namespace _06UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ddd = Console.ReadLine().Split();

            Dictionary<string, Dictionary<string, int>> sait = new Dictionary<string, Dictionary<string, int>>();
            string user = "Pesho";
            if (!sait.ContainsKey(user))
            {
                sait[user] = new Dictionary<string, int>();
            }
            else
            {
                Dictionary<string, int> ip = sait[user];
                if (!ip.ContainsKey("IP"))
                {
                    sait[user]["key"] = 10;
                }
            }
            foreach (var item in sait)
            {
                foreach (var fd in item.Value)
                {
                    
                }
            }
        }
    }
}
