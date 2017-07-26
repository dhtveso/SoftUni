using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    public class UniqueUsernames
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();

            for (int i = 0; i < input; i++)
            {
                var name = Console.ReadLine();
                set.Add(name);
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
