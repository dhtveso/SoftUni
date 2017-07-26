using System;
using System.Collections.Generic;
using System.Text;

namespace _14.DragonArmy
{
    public class DragonArmy
    {
        private const int DefaultDamage = 45;
        private const int DefaultHealth = 250;
        private const int DefaultArmor = 10;

        static void Main(string[] args)
        {
            var allDragons = new Dictionary<string, SortedDictionary<string, int[]>>();
            var numberOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDragons; i++)
            {
                var dragon = Console.ReadLine().Split();
                var type = dragon[0];
                var name = dragon[1];
                var damage = dragon[2].Equals("null") ? DefaultDamage : int.Parse(dragon[2]);
                var health = dragon[3].Equals("null") ? DefaultHealth : int.Parse(dragon[3]);
                var armor = dragon[4].Equals("null") ? DefaultArmor : int.Parse(dragon[4]);

                if (allDragons.ContainsKey(type))
                {
                    allDragons[type][name] = new int[] { damage, health, armor };
                }
                else
                {
                    allDragons[type] = new SortedDictionary<string, int[]>() { { name, new int[] { damage, health, armor } } };
                }
            }

            PrintAllDragons(allDragons);
        }

        private static void PrintAllDragons(Dictionary<string, SortedDictionary<string, int[]>> allDragons)
        {
            foreach (var type in allDragons)
            {
                var dragonTypeInfo = new StringBuilder();
                double avrDamage = 0, avrHealth = 0, avrArmor = 0;

                foreach (var dragon in type.Value)
                {
                    dragonTypeInfo.Append($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}\r\n");
                    avrDamage += dragon.Value[0];
                    avrHealth += dragon.Value[1];
                    avrArmor += dragon.Value[2];
                }

                avrDamage /= type.Value.Count;
                avrHealth /= type.Value.Count;
                avrArmor /= type.Value.Count;
                Console.WriteLine($"{type.Key}::({avrDamage:f2}/{avrHealth:f2}/{avrArmor:f2})");
                Console.Write(dragonTypeInfo.ToString());
            }
        }
    }
}
