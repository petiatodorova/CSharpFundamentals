using System;
using System.Collections.Generic;
using System.Linq;

namespace UnleashedFromColegata
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> singerVenues = new Dictionary<string, Dictionary<string, int>>();

            string line = Console.ReadLine();
            while (!line.Contains('@') || line[line.IndexOf('@') - 1] != ' ') //Checks for space before @
            {
                if (line == "End")   //Checks for End to get out of loop
                {
                    break;
                }
                line = Console.ReadLine();
            }
            string[] input = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0] != "End")
            {
                singerVenues = GetSingerInfo(singerVenues, input);
                line = Console.ReadLine();
                while (!line.Contains('@') || line[line.IndexOf('@') - 1] != ' ') //Checks for space before @
                {
                    if (line == "End")   //Checks for End to get out of loop
                    {
                        break;
                    }
                    line = Console.ReadLine();
                }
                input = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }


            foreach (var venue in singerVenues)
            {
                Console.WriteLine($"{venue.Key}");
                foreach (var singer in venue.Value.OrderByDescending(money => money.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }

        }

        static Dictionary<string, Dictionary<string, int>> GetSingerInfo(Dictionary<string, Dictionary<string, int>> singerVenues, string[] input)
        {
            //Checks for validity
            while (input.Length < 4)
            { input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray(); }
            //Gets singer name        
            int tempIndex = 0; //Keeps current index
            List<string> tempName = new List<string>();//Adds names to a temporary list
            string singerName = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].StartsWith('@'))
                {
                    if (tempName.Count > 3) //Checks if name is more than 3 words
                    {
                        return singerVenues;
                    }
                    singerName = string.Join(' ', tempName);
                    tempIndex = i;
                    input[i] = input[i].Remove(0, 1); //Removes '@'
                    break;
                }
                tempName.Add(input[i]);
            }
            //Gets venue name
            string venue = "";
            List<string> tempVenue = new List<string>();
            for (int i = tempIndex; i < input.Length; i++)
            {
                if (int.TryParse(input[i], out int result) == true) //Checks for digits
                {
                    if (tempVenue.Count > 3)
                    {
                        return singerVenues;
                    }
                    venue = string.Join(' ', tempVenue);
                    tempIndex = i;
                    break;
                }
                for (char j = '0'; j < '9'; j++)
                {
                    if (input[i].Contains(j))
                    {
                        return singerVenues;
                    }
                }
                tempVenue.Add(input[i]);
            }

            int ticketsPrice;
            bool ticketsPriceExists = int.TryParse(input[tempIndex], out ticketsPrice); //Checks if it's a number
            int ticketsCount;
            bool ticketsCountExists = int.TryParse(input[tempIndex + 1], out ticketsCount); // Checks if it's a number
            if (!ticketsPriceExists || !ticketsCountExists)
            {
                return singerVenues;
            }

            if (singerVenues.ContainsKey(venue) == false)
            {
                singerVenues.Add(venue, new Dictionary<string, int>()
            {
                 {singerName, ticketsCount*ticketsPrice}
            });
            }
            else if (singerVenues[venue].ContainsKey(singerName) == false)
            {
                singerVenues[venue].Add(singerName, ticketsCount * ticketsPrice);
            }
            else
            {
                singerVenues[venue][singerName] += ticketsCount * ticketsPrice;
            }
            return singerVenues;
        }
    }
}
