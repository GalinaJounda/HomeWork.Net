using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task54
{
    class Program
    {
        //Задача 54: Задайте двумерный массив.Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //В итоге получается вот такой массив:
        //7 4 2 1
        //9 5 3 2
        //8 4 4 2
        static void Main(string[] args)
        {
            int m = GetNumber("высоту");
            int n = GetNumber("ширину");

            int[,] matrix = GetMatrix(m, n);
            ShowMatrix(matrix);
            Console.WriteLine("----------------------");
            SortMatrixByLines(ref matrix);
            ShowMatrix(matrix);
            Console.ReadLine();
        }

        static int GetNumber(string input)
        {
            Console.WriteLine($"Введите {input}");
            var value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        static int[,] GetMatrix(int m, int n)
        {
            int[,] matrix = new int[m, n];
            var rand = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(0, 9);
                }
            }
            return matrix;
        }

        static void SortMatrixByLines(ref int[,] matrix)
        {
            int[,] sorted = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for(int k = j+1; k < matrix.GetLength(1); k++)
                    {
                        if (matrix[i, j] < matrix[i, k])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, j];
                            matrix[i, j] = temp;
                        }
                    }
                }
            }
        }

        static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j < matrix.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
