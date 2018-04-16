using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> site = new Dictionary<string, Dictionary<string, int>>();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            List<string> userLog = new List<string>();
            List<string> ipString = new List<string>();
            string user = "";
            string ip = "";

            while (commands[0] != "end")
            {
                userLog = commands[2].Split('=').ToList();
                user = userLog[1];
                ipString = commands[0].Split('=').ToList();
                ip = ipString[1];

                // IP=192.23.30.40 message='Hello&derps.' user=destroyer

                if (!site.ContainsKey(user))
                // addvame go s value 1
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(ip, 1);
                    site.Add(user, current);
                }
                else
                {
                    // proverka za IP-to
                    if (!site[user].ContainsKey(ip))
                    {
                        site[user].Add(ip, 1);
                    }
                    else
                    {
                        site[user][ip]++;
                    }
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var currentUser in site.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{currentUser.Key}: ");
                List<string> helpPrint = new List<string>();
                foreach (var ipLogs in currentUser.Value)
                {
                    helpPrint.Add($"{ipLogs.Key} => {ipLogs.Value}");

                }
                Console.WriteLine($"{string.Join(", ", helpPrint)}.");

            }

        }
    }
}
