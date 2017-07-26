using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var setN = new HashSet<int>();
            var setM = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                var n = int.Parse(Console.ReadLine());

                setN.Add(n);
            }

            for (int i = 0; i < input[1]; i++)
            {
                var m = int.Parse(Console.ReadLine());

                setM.Add(m);
            }

            foreach (var number in setN)
            {
                if (setM.Contains(number))
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
