using System;

namespace ExcellentResult
{
    public class ExcellentResult
    {
        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
