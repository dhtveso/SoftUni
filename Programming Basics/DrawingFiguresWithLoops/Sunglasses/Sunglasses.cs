using System;

namespace Sunglasses
{
    public class Sunglasses
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                if (row == 0 || row == n - 1)
                {
                    Console.Write(new string('*', 2 * n));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', 2 * n));
                }
                else
                {
                    Console.Write("*{0}*", new string('/', n * 2 - 2));

                    if (row == (n - 1) / 2)
                    {
                        Console.Write(new string('|', n));
                    }
                    else
                    {
                        Console.Write(new string(' ', n));
                    }
                    Console.Write("*{0}*", new string('/', n * 2 - 2));
                }

                Console.WriteLine();
            }
        }
    }
}
