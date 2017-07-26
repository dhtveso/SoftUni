using System;
using System.Collections.Generic;

namespace _06.AMinerTask
{
    public class AMinerTask
    {
        public static void Main()
        {
            var dict = new Dictionary<string, long>();
            var input = Console.ReadLine();
            var counter = 1;
            var quant = 0L;

            do
            {
                if (input == "stop")
                {
                    break;
                }
                if (input == null)
                {
                    Console.WriteLine("5");
                    break;
                }
                if (counter % 2 == 0)
                {
                    input = Console.ReadLine();
                }
                else
                {
                    quant = long.Parse(Console.ReadLine());
                }
                if (!dict.ContainsKey(input))
                {
                    dict[input] = quant;
                }
                else
                {
                    dict[input] += quant;
                }
                quant = 0;
                counter++;

            } while (input != "stop");

            foreach (var item in dict)
            {
                if (item.Key == "stop" && item.Value == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value); ;
                }
            }
        }
    }
}
