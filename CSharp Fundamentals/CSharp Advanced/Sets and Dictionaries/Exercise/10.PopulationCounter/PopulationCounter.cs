using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('|');
            var cityPopuation = new Dictionary<string, Dictionary<string, long>>();
            var countryPopulation = new Dictionary<string, long>();

            while (input[0] != "report")
            {
                var country = input[1];
                var city = input[0];
                var population = long.Parse(input[2]);

                if (!countryPopulation.ContainsKey(country) && !cityPopuation.ContainsKey(country))
                {
                    countryPopulation[country] = 0L;
                    cityPopuation[country] = new Dictionary<string, long>();
                }
                if (!cityPopuation[country].ContainsKey(city))
                {
                    cityPopuation[country][city] = 0L;
                }
                countryPopulation[country] += population;
                cityPopuation[country][city] += population;
                input = Console.ReadLine().Split('|');
            }

            foreach (var item in countryPopulation.OrderByDescending(key => key.Value))
            {
                Console.WriteLine("{0} (total population: {1})", item.Key, item.Value);
                var cities = cityPopuation[item.Key];

                foreach (var city in cities.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
