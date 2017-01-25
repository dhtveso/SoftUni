using System;

namespace Cinema
{
    public class Cinema
    {
        public static void Main()
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
