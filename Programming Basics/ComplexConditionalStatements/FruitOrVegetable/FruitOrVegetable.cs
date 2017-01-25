using System;

namespace FruitOrVegetable
{
    public class FruitOrVegetable
    {
        public static void Main()
        {
            var fruit = Console.ReadLine();

            if (fruit == "banana" || fruit == "apple" || fruit == "kiwi" || fruit == "lemon" || fruit == "cherry" || fruit == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (fruit == "tomato" || fruit == "cucumber" || fruit == "pepper" || fruit == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
