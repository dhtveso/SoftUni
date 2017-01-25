using System;

namespace LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftSum = 0;
            var rightSum = 0;

            for (var i = 0; i < n; i++)
            { 
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(rightSum - leftSum));
            }
        }
    }
}
