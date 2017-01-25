using System;

namespace CristmasTree
{
    public class CristmasTree
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.Write(new string(' ', n - i) + new string('*', i) + " | " + new string('*', i));
                Console.WriteLine();
            }
        }
    }
}
