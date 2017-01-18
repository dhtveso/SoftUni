using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitOrVegetable
{
    class fruitOrVegetable
    {
        static void Main(string[] args)
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
