using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEvenPosition
{
    class oddEvenPosition
    {
        static void Main(string[] args)
        {
            var countNumber = int.Parse(Console.ReadLine());
            var oddMaxValue = double.MinValue;
            var oddMinValue = double.MaxValue;
            var evenSum = 0d;
            var oddSum = 0d;
            var evenMaxValue = double.MinValue;
            var evenMinValue = double.MaxValue;

            for (int i = 1; i <= countNumber; i++)
            {
                var number = double.Parse(Console.ReadLine());

                if (i % 2 ==0)
                {
                    evenSum += number;
                    if (number < evenMinValue)
                    {
                        evenMinValue = number;
                    }
                    if (number > evenMaxValue)
                    {
                        evenMaxValue = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number < oddMinValue)
                    {
                        oddMinValue = number;
                    }
                    if (number > oddMaxValue)
                    {
                        oddMaxValue = number;
                    }
                }
                //if (number < oddMinValue && i % 2 != 0)
                //{
                //    oddMinValue = number;
                //}
                //if (number > oddMaxValue && i % 2 !=0)
                //{
                //    oddMaxValue = number;
                //}
                //if (number < evenMinValue && i % 2 == 0)
                //{
                //    evenMinValue = number;
                //}
                //if (number > evenMaxValue && i % 2 == 0)
                //{
                //    evenMaxValue = number;
                //}
            }
            Console.WriteLine("OddSum={0}", oddSum);
            if (oddMinValue == double.MaxValue)
            {
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
            }
            else
            {
                Console.WriteLine("OddMin={0}", oddMinValue);
                Console.WriteLine("OddMax={0}", oddMaxValue);
            }
            Console.WriteLine("EvenSum={0}", evenSum);
            if (evenMaxValue == double.MinValue)
            {
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMin={0}", evenMinValue);
                Console.WriteLine("EvenMax={0}", evenMaxValue);
            }
        }
    }
}
