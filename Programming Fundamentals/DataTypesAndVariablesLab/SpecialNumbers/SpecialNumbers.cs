﻿using System;

namespace SpecialNumbers
{
    public class SpecialNumbers
    {
        public static void Main()
        {
            int countingNumber = int.Parse(Console.ReadLine());

            for (int num = 1; num <= countingNumber; num++)
            {
                int sumOfDigits = 0;
                int digits = num;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                bool special = (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);

                Console.WriteLine($"{num} -> {special}");
            }
        }
    }
}
