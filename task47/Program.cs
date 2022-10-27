using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task47
{
    class Program
    {
        //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
        //m = 3, n = 4.
        //0,5 7 -2 -0,2
        //1 -3,3 8 -9,9
        //8 7,8 -7,1 9
        static void Main(string[] args)
        {
            int m = GetNumber("m");
            int n = GetNumber("n");
            int min = GetNumber("min");
            int max = GetNumber("max");

            double[,] matrix = GetMatrix(m, n, min, max);

            ShowMatrix(matrix);
            Console.ReadLine();
        }

        static int GetNumber(string input)
        {
            Console.WriteLine($"Введите переменную {input}");
            var value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        static double[,] GetMatrix(int m, int n, int min, int max)
        {
            double[,] matrix = new double[m, n];
            var rand = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = Math.Round(rand.Next(min, max) + rand.NextDouble(), 1);
                }
            }
            return matrix;
        }

        static void ShowMatrix(double[,] matrix)
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
