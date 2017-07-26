using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.CrossFire
{
    public class CrossFire
    {
        public static void Main()
        {
            var matrixDimention = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = matrixDimention[0];
            var cols = matrixDimention[1];
            var matrix = FillMatrix(rows, cols);

            var input = Console.ReadLine();

            while (input != "Nuke it from orbit")
            {
                var inputTokens = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var destroyedRow = inputTokens[0];
                var destroyedCol = inputTokens[1];
                var radius = inputTokens[2];

                for (int rowIndex = destroyedRow - radius; rowIndex <= destroyedRow + radius; rowIndex++)
                {
                    if (IsInMatrix(rowIndex, destroyedCol, matrix))
                    {
                        matrix[rowIndex][destroyedCol] = -1;
                    }
                }

                for (int colIndex = destroyedCol - radius; colIndex <= destroyedCol + radius; colIndex++)
                {
                    if (IsInMatrix(destroyedRow, colIndex, matrix))
                    {
                        matrix[destroyedRow][colIndex] = -1;
                    }
                }

                FilterMatrix(matrix);
                input = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void FilterMatrix(List<List<int>> matrix)
        {
            for (int rowIndex = matrix.Count - 1; rowIndex >= 0; rowIndex--)
            {
                for (int colIndex = matrix[rowIndex].Count - 1; colIndex >= 0; colIndex--)
                {
                    if (matrix[rowIndex][colIndex] == -1)
                    {
                        matrix[rowIndex].RemoveAt(colIndex);
                    }
                }

                if (matrix[rowIndex].Count == 0)
                {
                    matrix.RemoveAt(rowIndex);
                }
            }
        }

        private static void PrintMatrix(List<List<int>> matrix)
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }

        private static bool IsInMatrix(int currentRow, int currentCol, List<List<int>> matrix)
        {
            if (currentRow >= 0 && currentRow < matrix.Count &&
                currentCol >= 0 && currentCol < matrix[currentRow].Count)
            {
                return true;
            }
            return false;
        }

        private static List<List<int>> FillMatrix(int rows, int cols)
        {
            var matrix = new List<List<int>>();
            var counter = 1;

            for (int row = 0; row < rows; row++)
            {
                var line = new List<int>();
                matrix.Add(line);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row].Add(counter);
                    counter++;
                }
            }

            return matrix;
        }
    }
}