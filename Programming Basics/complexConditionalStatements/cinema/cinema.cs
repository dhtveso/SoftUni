using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var roll = int.Parse(Console.ReadLine());
            var colum = int.Parse(Console.ReadLine());
            var finalsum = 0d;

            if (type == "Premiere")
            {
                finalsum = roll * colum * 12.00;
            }
            else if (type == "Normal")
            {
                finalsum = roll * colum * 7.50;
            }
            else if (type == "Discount")
            {
                finalsum = roll * colum * 5.00;
            }
            Console.WriteLine("{0:F2}", finalsum);
            Console.WriteLine("Leva");
        }
    }
}
