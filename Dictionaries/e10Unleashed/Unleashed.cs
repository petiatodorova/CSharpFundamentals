using System;
using System.Collections.Generic;
using System.Linq;

namespace e10Unleashed
{
    class Unleashed
    {
        static void Main(string[] args)
        {
            //static void Main(string[] args)
            //{
            //    string vhod = Console.ReadLine();
            //    string[] insideProgram = Proba2(vhod);
            //    Console.WriteLine($"{string.Join(',', insideProgram)}");

            //}

            //private static string[] Proba2(string input)
            //{

            //    string[] stringProba = Console.ReadLine().Split(' ').ToArray();
            //    return stringProba;
            //}

            Dictionary<string, Dictionary<string, int>> serbian = new Dictionary<string, Dictionary<string, int>>();
            string[] input;
            string[] input1;

            input = Console.ReadLine().Split(" @").ToArray();
            while (input[0] != "End")
            {
                string name = input[0];
                bool resultPrice = false;
                bool resultCountTickets = false;
                while (!(resultCountTickets && resultPrice))
                {
                    while (input.Length != 2)
                    {
                        Console.WriteLine($"Невалиден ред. Въведи отново:");
                        input = Console.ReadLine().Split(" @").ToArray();
                    }

                    // следваща проверка за 2 int-a в края
                    string[] inputHelp = input[1].Split(' ').ToArray();
                    string place = inputHelp[0];
                    try
                    {
                        int.Parse(inputHelp[inputHelp.Length - 2]);
                        resultPrice = true;
                    }
                    catch
                    {
                        Console.WriteLine($"Невалиден ред. Въведи отново:");
                    }
                    try
                    {
                        int.Parse(inputHelp[inputHelp.Length - 1]);
                        resultCountTickets = true;
                    }
                    catch
                    {
                        Console.WriteLine($"Невалиден ред. Въведи отново:");
                    }
                    input = Console.ReadLine().Split(" @").ToArray();
                    // End of While for good row
                }
                Console.WriteLine($"OK");
                input1 = input[1].Split(' ').ToArray();
                int ticketsPrice = int.Parse(input1[input1.Length - 2]);
                int ticketsCount = int.Parse(input1[input1.Length - 1]);




                // End of while( not "End" )
            }



        }
    }
}
