using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbers
{
    public class ReverseNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var numbers = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            var stack = new Stack<int>(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{stack.Pop()} ");
            }
        }
    }
}