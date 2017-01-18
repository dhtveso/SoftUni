using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exactSumOfRealNumbers
{
    class exactSumOfRealNumbers
    {
        static void Main(string[] args)
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
