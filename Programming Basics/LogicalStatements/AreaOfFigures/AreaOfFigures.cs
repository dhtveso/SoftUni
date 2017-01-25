using System;

namespace AreaOfFigures
{
    public class AreaOfFigures
    {
        public static void Main()
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
