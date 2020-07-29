using System;

namespace MapeamentoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of lines and columns of the matrix: ");
            string[] lineColumns = Console.ReadLine().Split(' ');
            int line = int.Parse(lineColumns[0]);
            int columns = int.Parse(lineColumns[1]);

            int[,] matrix = new int[line, columns];

            Console.WriteLine("\nEnter the matrix values:");
            for (int i = 0; i < line; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("\nEnter the value for mapping: ");
            int mappingValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == mappingValue)
                    {
                        Console.WriteLine($"Position {i},{j}:");

                        if (j == (columns - 1))
                        {
                            Console.WriteLine("Left: " + matrix[i, j - 1]);
                        }
                        else if (j == 0)
                        {
                            Console.WriteLine("Right: " + matrix[i, j + 1]);
                        }
                        else
                        {
                            Console.WriteLine("Left: " + matrix[i, j - 1]);
                            Console.WriteLine("Right: " + matrix[i, j + 1]);
                        }

                        if (i == (line - 1))
                        {
                            Console.WriteLine("Up: " + matrix[i - 1, j]);
                        }
                        else if (i == 0)
                        {
                            Console.WriteLine("Down: " + matrix[i + 1, j]);
                        }

                        else
                        {
                            Console.WriteLine("Up: " + matrix[i - 1, j]);
                            Console.WriteLine("Down: " + matrix[i + 1, j]);
                        }
                    }
                }
            }



            //Console.WriteLine("Matrix:");
            //for (int i = 0; i < line; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write(matrix[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
