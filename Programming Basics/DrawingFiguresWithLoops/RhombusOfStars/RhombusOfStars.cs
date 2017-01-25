using System;

namespace RhombusOfStars
{
    public class RhombusOfStars
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));

                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', row - 1));

                for (int col = row; col <= n - 1; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}
