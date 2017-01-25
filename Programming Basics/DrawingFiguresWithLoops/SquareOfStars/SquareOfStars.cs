using System;

namespace SquareOfStars
{
    public class SquareOfStars
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int cow = 0; cow < n; cow++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
