using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var logs = new SortedDictionary<string, SortedList<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input[1];
                var ip = input[0];
                var duration = int.Parse(input[2]);

                if (!logs.ContainsKey(name))
                {
                    logs[name] = new SortedList<string, int>();
                }
                if (!logs[name].ContainsKey(ip))
                {
                    logs[name][ip] = duration;
                }
                else
                {
                    logs[name][ip] += duration;
                }
            }

            var timeHolder = 0;
            var ipHolder = "";

            foreach (var item in logs)
            {
                var last = item.Value.LongCount();
                Console.Write("{0}: ", item.Key);

                foreach (var ip in item.Value)
                {
                    if (last - 1 == 0)
                    {
                        ipHolder += ip.Key;
                    }
                    else
                    {
                        ipHolder += ip.Key + ", ";
                    }

                    timeHolder += ip.Value;
                    last--;
                }

                Console.WriteLine("{0} [{1}]", timeHolder, ipHolder);
                timeHolder = 0;
                ipHolder = "";
            }
        }
    }
}
