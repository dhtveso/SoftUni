using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PoisonPlants
{
    public class PoisonPlants
    {
        public static void Main()
        {
            var plantsNumber = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var daysPlantsDie = new int[plantsNumber];
            var previousPlant = new Stack<int>();
            previousPlant.Push(0);

            for (int i = 1; i < plantsNumber; i++)
            {
                int lastDay = 0;

                while (previousPlant.Count() > 0 && plants[previousPlant.Peek()] >= plants[i])
                {
                    lastDay = Math.Max(lastDay, daysPlantsDie[previousPlant.Pop()]);
                }

                if (previousPlant.Count() > 0)
                {
                    daysPlantsDie[i] = lastDay + 1;
                }
                previousPlant.Push(i);
            }

            Console.WriteLine(daysPlantsDie.Max());
        }
    }
}