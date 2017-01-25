using System;

namespace MinNumber
{
    public class MinNumber
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var min = int.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var numberCount = int.Parse(Console.ReadLine());

                if (numberCount < min)
                {
                    min = numberCount;
                }
            }
            Console.WriteLine(min);
        }
    }
}
