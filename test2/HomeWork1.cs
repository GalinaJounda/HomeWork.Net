using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class HomeWork1
    {
        static void Main(string[] args)
        {
         int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
            {
                int[,] matrix = new int[rows, columns];
                var rnd = new Random();

                for (int i = 0; i < matrix.GetLength(0); i++) //0 - rows 0
                {
                    for (int j = 0; j < matrix.GetLength(1); j++) //1 - columns
                    {
                        matrix[i, j] = rnd.Next(min, max + 1);
                    }                   
                }
                return matrix;
            }
          void Printatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.Write("[");
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
                        else Console.Write($"{matrix[i, j]}");
                    }
                    Console.Write("]");
                }
            }
            int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);

        }
    }
}
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max){
    int[] GetArrayFromMatrix(int[,] matrix)
    {
        int[] result = new int[matrix.Length];

        int index = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                result[index] = matrix[i, j];
                index++;

            }

        }

        return result;
        void PrintMatrixWithoutMin(int[,] matrix, int[] minIndex)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i != minIndex[0])
                {

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j != minIndex[1])
                        {
                            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} | ");
                            else Console.Write($"{matrix[i, j],2} ");

                        }

                    }
                    Console.WriteLine();
                }
            }
        }

    }
    // Задача 55: Задайте двумерный массив. Напишите программу,
    // которая заменяет строки на столбцы. В случае, если это
    // невозможно, программа должна вывести сообщение для
    // пользователя.
    int[,] DeleteMinRowsColumn(int[,] matrix, int[] minIndex)
    {
        int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
        int i1 = 0;
        int j1 = 0;
        for (int i = 0; i < result.GetLength(0); i++)
        {

            if (i1 == minIndex[0]) i1++;
            for (int j = 0; j < result.GetLength(1); j++)
            {
                if (j1 == minIndex[1]) j1++;
                result[i, j] = matrix[i1, j1];
                j1++;
            }
            i1++;
            j1 = 0;
        }
        return result;
        void PrintMatrixWithoutMin(int[,] matrix, int[] minIndex)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i != minIndex[0])
                {

                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j != minIndex[1])
                        {
                            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} | ");
                            else Console.Write($"{matrix[i, j],2} ");

                        }

                    }
                    Console.WriteLine();
                }
            }
        }



        void CountNPrintArrayGlossary(int[] localarray)
    {
        int num = localarray[0];
        int counter = 1;
        for (int i = 1; i < localarray.Length; i++)
        {
            if (num == localarray[i])
            {
                counter++;
            }
            else
            {
                Console.WriteLine($"{num} повторяется {counter} раз");
                num = localarray[i];
                counter = 1;
            }
        }
        Console.WriteLine($"{num} повторяется {counter} раз");

    }

    int[,] array2D = CreateMatrixRndInt(3, 3, 0, 10);
    int[] array = GetArrayFromMatrix(array2D);
    Array.Sort(array);

    PrintMatrix(array2D);
    CountNPrintArrayGlossary(array);

