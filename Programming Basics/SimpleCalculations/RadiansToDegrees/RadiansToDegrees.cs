using System;

namespace RadiansToDegrees
{
    public class RadiansToDegrees
    {
        public static void Main()
        {
            var radians = double.Parse(Console.ReadLine());
            double degrees = (180 / Math.PI) * radians;

            Console.WriteLine(Math.Round(degrees));
        }
    }
}
