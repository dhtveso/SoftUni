using System;

namespace SumNumbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            var Num = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < Num; i++)
            {
                var cifri = int.Parse(Console.ReadLine());
                sum += cifri;
            }

            Console.WriteLine(sum);
        }
    }
}
