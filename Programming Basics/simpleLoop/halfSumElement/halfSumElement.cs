using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halfSumElement
{
    class halfSumElement
    {
        static void Main(string[] args)
        {
            var countNumber = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxSum = int.MinValue;

            for (int i = 0; i < countNumber; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > maxSum)
                {
                    maxSum = number;
                }

            }
            if ((maxSum * 2) - sum == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", maxSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs((maxSum *2)- sum));
            }
        }
    }
}
