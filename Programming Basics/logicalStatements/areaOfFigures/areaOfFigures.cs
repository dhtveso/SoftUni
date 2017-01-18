using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfFigures
{
    class areaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double side = double.Parse(Console.ReadLine());
            if (figure == "square")
            {
                Console.WriteLine(side*side);
            }
            else if (figure == "circle")
            {
                var result = Math.PI * side * side;
                Console.WriteLine("{0:F3}", result);
            }
            if (figure == "rectangle")
            {
                double higher = double.Parse(Console.ReadLine());
                Console.WriteLine(side * higher);
            }
            else if (figure == "triangle")
            {
                double higher = double.Parse(Console.ReadLine());
                var result = 0.5 * side * higher;
                Console.WriteLine("{0}", result);
            }
        }
    }
}
