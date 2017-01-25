using System;

namespace PointOnRectangleBorder
{
    public class PointOnRectangleBorder
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var onleftside = (x == x1 && (y >= y1 && y <= y2));
            var onrightside = (x == x2 && (y > y1 && y <= y2));
            var ontopside = ((y == y1) && (x >= x1 && x <= x2));
            var downside = ((y == y2) && (x >= x1 && x <= x2));

            if (onleftside || onrightside || ontopside || downside)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
