using System;
using System.Collections.Generic;

namespace _04.CountSymbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new SortedDictionary<char, int>();

            foreach (var character in input)
            {
                if (!dict.ContainsKey(character))
                {
                    dict[character] = 1;
                }
                else
                {
                    dict[character]++;
                }
            }

            foreach (var character in dict)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
