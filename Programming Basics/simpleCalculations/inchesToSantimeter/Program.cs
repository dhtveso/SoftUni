using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchesToSantimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inch = double.Parse(Console.ReadLine());
            var Santimeter = inch * 2.54;
            Console.Write("Santimeter= ");
            Console.WriteLine(Santimeter);
        }
    }
}
