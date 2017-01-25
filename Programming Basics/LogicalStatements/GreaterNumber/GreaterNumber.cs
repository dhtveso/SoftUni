using System;

namespace FreaterNumber
{
    public class GreaterNumber
    {
        public static void Main()
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
    }
}
