using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterUSDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD: ");
            double USD = double.Parse(Console.ReadLine());
            double Lev = USD * 1.79549;
            Console.WriteLine("Lev = {0:F2}", Lev);
        }
    }
}
