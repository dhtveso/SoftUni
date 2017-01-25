using System;

namespace TrapeziodArea
{
    public class TrapeziodArea
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (a + b) * h / 2;

            Console.WriteLine("Trapeoid = {0}", area);
        }
    }
}
