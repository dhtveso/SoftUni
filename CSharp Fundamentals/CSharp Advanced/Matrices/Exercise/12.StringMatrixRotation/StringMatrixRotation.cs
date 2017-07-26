using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.StringMatrixRotation
{
    public class StringMatrixRotation
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var rotation = input
                .Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var degree = int.Parse(rotation[1]);
            var list = new List<string>();

            while (input != "END")
            {
                list.Add(input);
                input = Console.ReadLine();
            }

            list.RemoveAt(0);
            string[][] matrix = new string[list.Count][];

            for (int i = 0; i < matrix.Length; i++)
            {
                var arrayString = new[] { list[i] };
                matrix[i] = arrayString;
            }

            if (degree % 360 == 0)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    Console.WriteLine(string.Join(" ", matrix[i]));
                }
            }
            else if (degree % 360 == 180)
            {
                for (int row = matrix.Length - 1; row >= 0; row--)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        Console.WriteLine(string.Join("", matrix[row][col].Reverse()));
                    }
                }
            }
            else if (degree % 360 == 90 || degree % 360 == 270)
            {
                var maxLenght = 0;

                for (int row = 0; row < matrix.Length; row++)
                {
                    var currentLenght = 0;

                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        currentLenght = matrix[row][col].Length;
                    }

                    if (maxLenght < currentLenght)
                    {
                        maxLenght = currentLenght;
                    }
                }

                char[][] reversedMatrix = new char[maxLenght][];

                for (int i = 0; i < reversedMatrix.Length; i++)
                {
                    char[] letter = new char[matrix.Length];
                    reversedMatrix[i] = letter;
                }

                for (int row = 0; row < matrix.Length; row++)
                {
                    char[] letter = new char[maxLenght];

                    for (int col = 0; col < 1; col++)
                    {
                        letter = matrix[row][col].ToCharArray();
                    }

                    for (int rowChar = 0; rowChar < reversedMatrix.Length; rowChar++)
                    {
                        for (int colChar = 0; colChar < 1; colChar++)
                        {
                            if (letter.Length > rowChar)
                            {
                                reversedMatrix[rowChar][matrix.Length - 1 - row] = letter[rowChar];
                            }
                        }
                    }
                }

                for (int row = 0; row < reversedMatrix.Length; row++)
                {
                    for (int col = 0; col < reversedMatrix[row].Length; col++)
                    {
                        if (reversedMatrix[row][col] == '\0')
                        {
                            reversedMatrix[row][col] = ' ';
                        }
                    }
                }

                if (degree % 360 == 90)
                {
                    for (int row = 0; row < reversedMatrix.Length; row++)
                    {
                        Console.WriteLine(string.Join("", reversedMatrix[row]).Trim());
                    }
                }
                else
                {
                    for (int row = reversedMatrix.Length - 1; row >= 0; row--)
                    {
                        for (int col = 0; col < 1; col++)
                        {
                            Console.WriteLine(string.Join("", reversedMatrix[row].Reverse()));
                        }
                    }
                }
            }
        }
    }
}