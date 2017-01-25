using System;

namespace RefactorSpecialNumbers
{
    public class RefactorSpecialNumbers
    {
        public static void Main()
        {
            int numberCount = int.Parse(Console.ReadLine());

            for (int num = 1; num <= numberCount; num++)
            {
                int sumOfDigits = 0;
                int digits = num;

                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }

                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{digits} -> {special}");
                num = digits;
            }

        }
    }
}
