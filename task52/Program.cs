using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task52
{
    class Program
    {
        //Задача 52. Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
        static void Main(string[] args)
        {
            int m = GetNumber("высоту");
            int n = GetNumber("ширину");

            int[,] matrix = GetMatrix(m, n);
            double[] averages = GetAveragesByColumn(matrix);

            ShowMatrix(matrix);
            Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", averages)}");
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

        static double[] GetAveragesByColumn(int[,] matrix)
        {
            double[] result = new double[matrix.GetLength(1)];

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sum += matrix[i, j];
                }
                result[j] = Math.Round((double)sum / matrix.GetLength(0), 2);
            }
            return result;
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
