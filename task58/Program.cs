using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task58
{
    class Program
    {
        //Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
        //Например, даны 2 матрицы:
        //2 4 | 3 4
        //3 2 | 3 3
        //Результирующая матрица будет:
        //18 20
        //15 18
        static void Main(string[] args)
        {
            int l = GetNumber("высоту 1й матрицы");
            int m = GetNumber("ширину 2й матрицы и высоту 2й матрицы");
            int n = GetNumber("ширину 2й матрицы");
            Console.WriteLine("----------------------");
            int[,] matrix1 = GetMatrix(l, m);
            int[,] matrix2 = GetMatrix(m, n);

            ShowMatrix(matrix1);
            Console.WriteLine("----------------------");
            ShowMatrix(matrix2);
            Console.WriteLine("----------------------");

            int[,] matrix3 = MultiplyMatrix(matrix1, matrix2);
            ShowMatrix(matrix3);
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

        static void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 3}");
                    if (j < matrix.GetLength(1) - 1)
                    {
                        Console.Write(" | ");
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }

        static int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }
    }
}
