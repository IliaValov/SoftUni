using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> playersWithCards = new Dictionary<string, List<string>>();


            while (true)
            {

                string input = Console.ReadLine();
                string[] playerAndCards = input.Split(": ").ToArray();
                if (playerAndCards[0] == "JOKER")
                {
                    break;
                }
                List<string> cards = playerAndCards[1].Split(", ").ToList();
                if (playersWithCards.ContainsKey(playerAndCards[0]))
                {
                    
                    playersWithCards[playerAndCards[0]].AddRange(cards);
                }
                else
                {
                    playersWithCards.Add(playerAndCards[0], cards);
                }
            }

            while (true)
            {
                List<string> resultCards = new List<string>();
                string name = "";
                foreach (var item in playersWithCards)
                {
                    resultCards = item.Value;
                }
            }


        }
        static int SumOfCards(string cards)
        {
            int result = PowerCard(cards) * TypeCard(cards);
            return result;
        }

        static int PowerCard(string power)
        {
            Dictionary<string, int> powerCard = new Dictionary<string, int> { {"J",11 },{"Q",12},{"K",13 },{"A",14 } };
            string takePower = power.Remove(power.Length - 1);
            int result = 0;

            if (powerCard.ContainsKey(takePower))
            {
                result = powerCard[takePower];
            }
            else
            {
                result = int.Parse(takePower);
            }
            return result;
            


        }
        static int TypeCard(string type)
        {
            Dictionary<string, int> typeCard = new Dictionary<string, int> { { "S", 4 }, { "H", 3 }, { "D", 2 }, { "C", 1 } };
            string lastChar = type.TakeLast(1).ToString();
            int result = typeCard[lastChar];
            return result;
        }
    }
}
