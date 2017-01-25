using System;

namespace OddEvenSum
{
    public class OddEvenSum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < n; i++)
            {

                int currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else if (i % 2 != 0)
                {
                    sumOdd += currentNumber;
                }
            }

            if ((sumEven - sumOdd) == 0)
            {
                Console.WriteLine("Yes Sum {0}", sumOdd);
            }
            else
            {
                Console.WriteLine("No Diff {0}", Math.Abs(sumOdd - sumEven));
            }
        }
    }
}
