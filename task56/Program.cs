using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task56
{
    class Program
    {
        //Задача 56: Задайте прямоугольный двумерный массив.Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //5 2 6 7
        //Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
        static void Main(string[] args)
        {
            int m = GetNumber("высоту");
            int n = GetNumber("ширину");
            Console.WriteLine("----------------------");
            int[,] matrix = GetMatrix(m, n);
            ShowMatrix(matrix);
            Console.WriteLine("----------------------");
            int index = GetMinimalLineIndex(matrix);
            Console.WriteLine($"{index + 1} строка");
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

        static int GetMinimalLineIndex(int[,] matrix)
        {
            int[] sums = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sums[i] = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sums[i] += matrix[i, j];
                }
            }

            Console.WriteLine($"sums = [{string.Join(", ", sums)}]");
            return GetMinIndex(sums);
        }

        static int GetMinIndex(int[] array)
        {
            int result = 0;
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] < min)
                {
                    min = array[i];
                    result = i;
                }
            }
            return result;
        }
    }
}
