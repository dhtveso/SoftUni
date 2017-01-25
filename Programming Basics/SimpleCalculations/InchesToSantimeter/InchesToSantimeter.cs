using System;

namespace InchesToSantimeter
{
    public class InchesToSantimeter
    {
        public static void Main()
        {
            Console.Write("Inches = ");

            var inch = double.Parse(Console.ReadLine());
            var Santimeter = inch * 2.54;

            Console.Write("Santimeter= ");
            Console.WriteLine(Santimeter);
        }
    }
}
