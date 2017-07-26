using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var scores = new Dictionary<string, int>();
            var allData = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine()
                .Split(new char[] { ':' }).ToList();
                var name = input[0];

                if (name == "JOKER")
                {
                    break;
                }

                if (!allData.ContainsKey(name))
                {
                    allData[name] = input[1];
                }
                else
                {
                    allData[name] += input[1];
                }
            }

            foreach (var item in allData)
            {
                var list = new List<string>();
                list = item.Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                int sumOfHand = 0;

                foreach (var card in list)
                {
                    sumOfHand += PowerOfCard(card);
                }

                if (!scores.ContainsKey(item.Key))
                {
                    scores[item.Key] = sumOfHand;
                }
                else
                {
                    scores[item.Key] += sumOfHand;
                }
            }

            foreach (var score in scores)
            {
                Console.WriteLine("{0}: {1}", score.Key, score.Value);
            }
        }

        private static int PowerOfCard(string card)
        {
            string power = card[0].ToString();
            string type = card[card.Length - 1].ToString();

            if (power == "1")
            {
                power = "10";
            }
            int powerAsNumber = 0;
            int typeAsNumber = 0;
            bool nPower = int.TryParse(power, out powerAsNumber);

            if (nPower == false)
            {
                switch (power)
                {
                    case "J":
                        powerAsNumber = 11;
                        break;
                    case "Q":
                        powerAsNumber = 12;
                        break;
                    case "K":
                        powerAsNumber = 13;
                        break;
                    case "A":
                        powerAsNumber = 14;
                        break;
                    default:
                        break;
                }
            }
            switch (type)
            {
                case "C":
                    typeAsNumber = 1;
                    break;
                case "D":
                    typeAsNumber = 2;
                    break;
                case "H":
                    typeAsNumber = 3;
                    break;
                case "S":
                    typeAsNumber = 4;
                    break;
                default:
                    break;
            }
            var cardToNumber = powerAsNumber * typeAsNumber;
            return cardToNumber;
        }
    }
}
