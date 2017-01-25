using System;

namespace TriangleOfDolars
{
    public class TriangleOfDolars
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int cow = 0; cow <= row; cow++)
                {
                    Console.Write("$ ");
                }

                Console.WriteLine();
            }
        }
    }
}
