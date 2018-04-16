using System;
using System.Collections.Generic;
using System.Linq;

namespace _08LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();
            int countUserLogs = int.Parse(Console.ReadLine());

            for (int lines = 0; lines < countUserLogs; lines++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string user = input[1];
                string ip = input[0];
                int duration = int.Parse(input[2]);
                if (!logs.ContainsKey(user))
                {
                    Dictionary<string, int> ipTime = new Dictionary<string, int>();
                    ipTime.Add(ip, duration);
                    logs.Add(user, ipTime);
                }
                else
                {
                    if (!logs[user].ContainsKey(ip))
                    {
                        logs[user].Add(ip, duration);
                    }
                    else
                    {
                        logs[user][ip] += duration;
                    }
                }
            }

            //alex: 62[10.10.17.33, 212.50.118.81]
            foreach (var currentUser in logs.OrderBy(x => x.Key))
            {
                Console.Write($"{currentUser.Key}: {currentUser.Value.Values.Sum()} ");
                List<string> helpPrint = new List<string>();
                foreach (var pairIpTime in currentUser.Value.OrderBy(y => y.Key))
                {
                    helpPrint.Add(pairIpTime.Key);
                }
                Console.Write($"[{string.Join(", ", helpPrint)}]");
                Console.WriteLine($"");
            }
        }
    }
}
