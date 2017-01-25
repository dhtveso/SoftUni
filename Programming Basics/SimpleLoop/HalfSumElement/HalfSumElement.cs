using System;


namespace HalfSumElement
{
    public class HalfSumElement
    {
        public static void Main()
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
