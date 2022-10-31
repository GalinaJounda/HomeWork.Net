using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task60
{
    class Program
    {
        //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
        //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        //Массив размером 2 x 2 x 2
        //66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
        //34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
        static void Main(string[] args)
        {
            int l = GetNumber("длину");
            int m = GetNumber("ширину");
            int n = GetNumber("высоту");
            Console.WriteLine("----------------------");
            int[,,] matrix = GetMatrix(l, m, n);
            ShowMatrix(matrix);
            Console.ReadLine();
        }

        static int GetNumber(string input)
        {
            Console.WriteLine($"Введите {input}");
            var value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        static int[,,] GetMatrix(int l, int m, int n)
        {
            int[,,] matrix = new int[l, m, n];
            var rand = new Random();

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        matrix[i, j, k] = rand.Next(10, 99);
                    }
                }
            }
            return matrix;
        }

        static void ShowMatrix(int[,,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        Console.WriteLine($"{matrix[i, j, k]} ({i}, {j}, {k})");
                    }
                }
            }
        }
    }
}
