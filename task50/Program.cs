using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task50
{
    class Program
    {
        //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
        //и возвращает значение этого элемента или же указание, что такого элемента нет.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //1, 7 -> такого элемента в массиве нет
        static void Main(string[] args)
        {
            int m = GetNumber("высоту");
            int n = GetNumber("ширину");
            int[] coords = GetCoordinates();

            int[,] matrix = GetMatrix(m, n);

            string result = CheckMatrix(matrix, coords[0], coords[1]);

            ShowMatrix(matrix);
            Console.WriteLine($"({string.Join(", ", coords)}) -> {result}");
            Console.ReadLine();
        }

        static int GetNumber(string input)
        {
            Console.WriteLine($"Введите {input}");
            var value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        static int[] GetCoordinates()
        {
            Console.WriteLine("Введите координаты через запятую");
            var value = Console.ReadLine();
            var strings = value.Split(new string[] { ", ", "," }, StringSplitOptions.RemoveEmptyEntries);
            var coords = new int[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                coords[i] = Convert.ToInt32(strings[i]);
            }
            return coords;
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

        static string CheckMatrix(int[,] matrix, int x, int y)
        {
            if(x > 0 && x <= matrix.GetLength(0) && y > 0 && y <= matrix.GetLength(1))
            {
                return $"{matrix[x-1, y-1]}";
            }
            return "такого элемента в массиве нет";
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
