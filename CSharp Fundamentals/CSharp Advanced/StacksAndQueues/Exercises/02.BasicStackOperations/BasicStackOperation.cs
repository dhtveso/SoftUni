using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    public class BasicStackOperation
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
            var stackElement = input[0];
            var popedElement = input[1];
            var searchingNumber = input[2];
            var stackNumbers = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
            var stack = new Stack<int>(stackNumbers);

            if (popedElement >= stackElement)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 0; i < popedElement; i++)
                {
                    stack.Pop();
                }

                if (stack.Contains(searchingNumber))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}