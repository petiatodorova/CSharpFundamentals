﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Unleashed
{
    class Unleashed
    {
        static void Main(string[] args)
        {
            string singer = "";
            string venue = "";
            int price = 0;
            int tickets = 0;
            int income = 0;

            Dictionary<string, Dictionary<string, int>> concerts = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                if (!IsValid(input))
                {
                    input = Console.ReadLine();
                    continue;
                }

                string[] goodInput = input.Split('@').ToArray();
                singer = goodInput[0].Trim();

                List<string> helperRight = goodInput[1].Split(' ').ToList();

                price = int.Parse(helperRight[helperRight.Count - 1]);
                tickets = int.Parse(helperRight[helperRight.Count - 2]);
                income = price * tickets;
                helperRight.RemoveRange(helperRight.Count - 2, 2);
                venue = string.Join(" ", helperRight).Trim();

                //venue || => singer | => income
                if (!concerts.ContainsKey(venue))
                {
                    Dictionary<string, int> currentSinger = new Dictionary<string, int>();
                    currentSinger.Add(singer, income);
                    concerts.Add(venue, currentSinger);
                }
                else
                {
                    if (!concerts[venue].ContainsKey(singer))
                    {
                        concerts[venue].Add(singer, income);
                    }
                    else
                    {
                        concerts[venue][singer] += income;
                    }
                }

                input = Console.ReadLine();
            }

            //pechat
            foreach (var venuePair in concerts)
            {
                Console.WriteLine($"{venuePair.Key}");

                foreach (var singerPair in venuePair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singerPair.Key} -> {singerPair.Value}");
                }
            }
        }

        static bool IsValid(string input)
        {
            if (input.Length < 8)
            {
                return false;
            }
            if (!input.Contains('@') || input.IndexOf('@') == 0)
            {
                return false;
            }
            else
            {
                string[] helper1 = input.Split('@');
                if (helper1.Length != 2 || !helper1[0].EndsWith(" "))
                {
                    return false;
                }
                else
                {
                    string[] singerInfo = helper1[0].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    string[] venueAndPriceInfo = helper1[1].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (singerInfo.Length > 3 || singerInfo.Length < 1 || venueAndPriceInfo.Length < 3 || venueAndPriceInfo.Length > 5)
                    {
                        return false;
                    }
                    else
                    {
                        try
                        {
                            int.Parse(venueAndPriceInfo[venueAndPriceInfo.Length - 2]);
                            int.Parse(venueAndPriceInfo[venueAndPriceInfo.Length - 1]);
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
