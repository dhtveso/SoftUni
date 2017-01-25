using System;

namespace ExactSumOfRealNumbers
{
    public class ExactSumOfRealNumbers
    {
        public static void Main()
        {
            int countingNumber = int.Parse(Console.ReadLine());
            decimal sum = 0M;

            for (int i = 0; i < countingNumber; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());

                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
