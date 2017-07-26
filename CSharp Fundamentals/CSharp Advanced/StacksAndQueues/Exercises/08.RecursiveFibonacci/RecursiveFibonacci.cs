using System;
using System.Collections.Generic;

namespace _08.RecursiveFibonacci
{
    public class RecursiveFibonacci
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var fib = new Dictionary<int, long>();

            Console.WriteLine(Fibonacci(number, fib));
        }

        private static long Fibonacci(int n, IDictionary<int, long> fib)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else if (fib.ContainsKey(n))
            {
                return fib[n];
            }
            else
            {
                var current = Fibonacci(n - 2, fib) + Fibonacci(n - 1, fib);
                if (!fib.ContainsKey(n))
                {
                    fib.Add(n, current);
                }
                return current;
            }
        }
    }
}