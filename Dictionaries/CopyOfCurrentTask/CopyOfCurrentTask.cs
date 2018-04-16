using System;
using System.Collections.Generic;
using System.Linq;

namespace CopyOfCurrentTask
{
    class CopyOfCurrentTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> serbian = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split('@').ToArray();

            while (true)
            {
                if (input[0] == "End")
                {
                    break;
                }

                string[] inputHelp = input[1].Split(' ').ToArray();
                bool isPrice = false;
                bool isCount = false;

                try
                {
                    int.Parse(inputHelp[inputHelp.Length - 2]);
                    isPrice = true;
                }
                catch
                {
                    Console.WriteLine($"Невалиден ред. Въведи отново:");

                }

                try
                {
                    int.Parse(inputHelp[inputHelp.Length - 1]);
                    isCount = true;
                }
                catch
                {
                    Console.WriteLine($"Невалиден ред. Въведи отново:");
                }

                if (isCount == false || isPrice == false)
                {
                    input = Console.ReadLine().Split('@').ToArray();
                }

                Console.WriteLine($"OK");

                int ticketsPrice = int.Parse(venuePriceCount[venuePriceCount.Length - 2]);
                int ticketsCount = int.Parse(venuePriceCount[venuePriceCount.Length - 1]);
                string singer = input[0];
                string place = inputHelp[0];

            }
                

                

                // End of while( not "End" )
            }



        }
    }
}
