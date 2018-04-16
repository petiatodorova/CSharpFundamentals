using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            string[] commands = Console.ReadLine().Split(": ").ToArray();
            string name = "";
            List<string> cards = new List<string>();

            // Пълним Dictionary-to
            while (commands[0] != "JOKER")
            {
                name = commands[0];
                cards = commands[1].Split(", ").Distinct().ToList();
                if (!players.ContainsKey(name))
                {
                    players.Add(name, cards);
                }
                else
                {
                    players[name].AddRange(cards);
                    players[name] = players[name].Distinct().ToList();
                }
                commands = Console.ReadLine().Split(": ").ToArray();
            }

            foreach (var player in players)
            {
                int sum = 0;
                int cardPower = 0;
                int cardMultiplyer = 0;
                foreach (var card in player.Value)
                {
                    switch (card.Last())
                    {
                        case 'S':
                            cardMultiplyer = 4;
                            break;
                        case 'H':
                            cardMultiplyer = 3;
                            break;
                        case 'D':
                            cardMultiplyer = 2;
                            break;
                        case 'C':
                            cardMultiplyer = 1;
                            break;
                    }

                    string valueCard = card.Remove(card.Length - 1, 1);

                    // J, Q, K, A are 11 to 14
                    switch (valueCard)
                    {
                        case "J":
                            cardPower = 11;
                            break;
                        case "Q":
                            cardPower = 12;
                            break;
                        case "K":
                            cardPower = 13;
                            break;
                        case "A":
                            cardPower = 14;
                            break;
                        default:
                            cardPower = int.Parse(valueCard);
                            break;
                    }
                    sum += cardPower * cardMultiplyer;
                }
                Console.WriteLine($"{player.Key}: {sum}");
            }
        }
    }
}
