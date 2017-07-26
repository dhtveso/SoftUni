using System;
using System.Collections.Generic;

namespace _09.UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            var dict = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    break;
                }
                var name = input[input.Length - 1];
                var ip = input[1];

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new Dictionary<string, int>();
                }
                if (!dict[name].ContainsKey(ip))
                {
                    dict[name][ip] = 0;
                }
                dict[name][ip]++;
            }

            foreach (var name in dict)
            {
                Console.WriteLine("{0}:", name.Key);
                var ipholder = new List<string>();

                foreach (var item in name.Value)
                {
                    ipholder.Add(item.Key + " => " + item.Value);
                }

                Console.WriteLine("{0}.", string.Join(", ", ipholder));
            }
        }
    }
}
