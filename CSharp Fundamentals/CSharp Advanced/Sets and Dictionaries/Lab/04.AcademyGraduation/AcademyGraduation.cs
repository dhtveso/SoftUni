using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AcademyGraduation
{
    public class AcademyGraduation
    {
        public static void Main()
        {
            var numberCount = int.Parse(Console.ReadLine());
            var nameWhitGraduation = new SortedDictionary<string, double>();

            for (int i = 0; i < numberCount; i++)
            {
                var studentName = Console.ReadLine();
                var studentScore = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                if (!nameWhitGraduation.ContainsKey(studentName))
                {
                    nameWhitGraduation[studentName] = studentScore.Average();
                }
                else
                {
                    nameWhitGraduation[studentName] += studentScore.Average() / 2;
                }
            }

            foreach (var kvp in nameWhitGraduation)
            {
                Console.WriteLine($"{kvp.Key} is graduated with {kvp.Value}");
            }
        }
    }
}