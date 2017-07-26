using System;
using System.Linq;

namespace _02.SquareWithMaximumSum
{
    public class SquareWithMaximumSum
    {
        public static void Main()
        {
            var rowCol = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = rowCol[0];
            var cols = rowCol[1];
            int[][] matrix = new int[rows][];
            int maxSum = int.MinValue;
            int sum = 0;
            var topLeft = 0;
            var topRight = 0;
            var bottomLeft = 0;
            var bottomRight = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                var matrixLine = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                matrix[i] = matrixLine;
            }

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    sum = matrix[row][col] + matrix[row + 1][col] + matrix[row][col + 1] + matrix[row + 1][col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        topLeft = matrix[row][col];
                        topRight = matrix[row][col + 1];
                        bottomLeft = matrix[row + 1][col];
                        bottomRight = matrix[row + 1][col + 1];
                    }
                }
            }

            Console.WriteLine($"{topLeft} {topRight}");
            Console.WriteLine($"{bottomLeft} {bottomRight}");
            Console.WriteLine(maxSum);
        }
    }
}
