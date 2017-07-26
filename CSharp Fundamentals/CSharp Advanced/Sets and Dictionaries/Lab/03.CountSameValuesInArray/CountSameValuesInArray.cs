using System;
using System.Collections.Generic;
using System.Globalization;

namespace _03.CountSameValuesInArray
{
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var dict = new SortedDictionary<double, int>();
            var inputArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in inputArr)
            {
                string reminder;
                if (token.Contains(","))
                {
                    reminder = token.Replace(",", ".");
                }
                var result = double.Parse(token, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture);

                if (!dict.ContainsKey(result))
                {
                    dict[result] = 1;
                }
                else
                {
                    dict[result]++;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}