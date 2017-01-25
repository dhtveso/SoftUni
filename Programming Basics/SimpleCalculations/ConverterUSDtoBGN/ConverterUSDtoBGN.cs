using System;

namespace ConverterUSDtoBGN
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("USD: ");

            double USD = double.Parse(Console.ReadLine());
            double Lev = USD * 1.79549;

            Console.WriteLine("Lev = {0:F2}", Lev);
        }
    }
}
