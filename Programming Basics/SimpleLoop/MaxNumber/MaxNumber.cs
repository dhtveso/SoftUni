using System;

namespace MaxNumber
{
    public class MaxNumber
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                var numberCount = int.Parse(Console.ReadLine());

                if (numberCount > max)
                {
                    max = numberCount;
                }
            }
            Console.WriteLine(max);
        }
    }
}
