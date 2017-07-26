using System;
using System.Collections.Generic;
using System.Text;

namespace _03.PeriodicTable
{
    public class PeriodicTable
    {
        public static void Main()
        {
            var numberCount = int.Parse(Console.ReadLine());
            var elementSet = new HashSet<string>();

            for (int i = 0; i < numberCount; i++)
            {
                var elements = Console.ReadLine()
                    .Split(' ');

                foreach (var element in elements)
                {
                    elementSet.Add(element);
                }
            }

            var stringBuilder = new StringBuilder();

            foreach (var element in elementSet)
            {
                stringBuilder.Append(element).Append(" ");
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
