using System;
using System.Linq;

namespace _04.MaximalSum
{
    public class MaximalSum
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var maxSum = int.MinValue;
            var currentSum = 0;
            int[][] maxHolder = new int[3][];
            var num1 = 0;
            var num2 = 0;
            var num3 = 0;
            var num4 = 0;
            var num5 = 0;
            var num6 = 0;
            var num7 = 0;
            var num8 = 0;
            var num9 = 0;
            int[][] matrix = new int[input[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                var numberLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                matrix[i] = numberLine;
            }

            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2]
                        + matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2]
                        + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        num1 = matrix[row][col];
                        num2 = matrix[row][col + 1];
                        num3 = matrix[row][col + 2];
                        num4 = matrix[row + 1][col];
                        num5 = matrix[row + 1][col + 1];
                        num6 = matrix[row + 1][col + 2];
                        num7 = matrix[row + 2][col];
                        num8 = matrix[row + 2][col + 1];
                        num9 = matrix[row + 2][col + 2];
                    }
                }
            }

            Console.WriteLine("Sum = {0}", maxSum);
            Console.WriteLine($"{num1} {num2} {num3}");
            Console.WriteLine($"{num4} {num5} {num6}");
            Console.WriteLine($"{num7} {num8} {num9}");
        }
    }
}