﻿using System;

namespace SquareFrame
{
    public class SquareFrame
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    for (int col = 1; col <= n; col++)
                    {
                        if (col == 1 || col == n)
                        {
                            Console.Write("+ ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                }
                else
                {
                    for (int col = 1; col <= n; col++)
                    {
                        if (col == 1 || col == n)
                        {
                            Console.Write("| ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
