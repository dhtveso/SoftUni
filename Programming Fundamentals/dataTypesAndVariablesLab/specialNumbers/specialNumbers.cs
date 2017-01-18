using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialNumbers
{
    class specialNumbers
    {
        static void Main(string[] args)
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
