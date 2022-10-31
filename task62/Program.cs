using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task62
{
    class Program
    {
        //Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
        //Например, на выходе получается вот такой массив:
        //01 02 03 04
        //12 13 14 05
        //11 16 15 06
        //10 09 08 07
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];
            SpiralFillMatrix(ref matrix);
            ShowMatrix(matrix);
            Console.ReadLine();
        }

        static void SpiralFillMatrix(ref int[,] matrix)
        {
            int counter = 1;
            int filledLinesTop = 0;
            int filledLinesBottom = 0;
            int filledColumnsLeft = 0;
            int filledColumnsRight = 0;

            while(filledLinesTop + filledLinesBottom < matrix.GetLength(0) && filledColumnsLeft + filledColumnsRight < matrix.GetLength(1))
            {
                if (filledLinesTop + filledLinesBottom < matrix.GetLength(0))
                {
                    FillLineToRight(ref matrix, ref counter, filledLinesTop, filledColumnsLeft, matrix.GetLength(1) - 1 - filledColumnsRight);
                    filledLinesTop++;
                }

                if (filledColumnsLeft + filledColumnsRight < matrix.GetLength(1))
                {
                    FillColumnToBottom(ref matrix, ref counter, matrix.GetLength(1) - 1 - filledColumnsRight, filledLinesTop - 1, matrix.GetLength(0) - 1 - filledLinesBottom);
                    filledColumnsRight++;
                }

                if (filledLinesTop + filledLinesBottom < matrix.GetLength(0))
                {
                    FillLineToLeft(ref matrix, ref counter, matrix.GetLength(0) - 1 - filledLinesBottom, matrix.GetLength(1) - filledColumnsRight, filledColumnsLeft);
                    filledLinesBottom++;
                }

                if (filledColumnsLeft + filledColumnsRight < matrix.GetLength(1))
                {
                    FillColumnToTop(ref matrix, ref counter, filledColumnsLeft, matrix.GetLength(0) - filledLinesBottom, filledLinesTop - 1);
                    filledColumnsLeft++;
                }
            }
        }

        static void FillLineToRight(ref int[,] matrix, ref int counter, int line, int from, int to)
        {
            for (int j = from; j < to; j++)
            {
                matrix[line, j] = counter++;
            }
        }

        static void FillLineToLeft(ref int[,] matrix, ref int counter, int line, int from, int to)
        {
            for (int j = from; j > to; j--)
            {
                matrix[line, j] = counter++;
            }
        }

        static void FillColumnToBottom(ref int[,] matrix, ref int counter, int column, int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                matrix[i, column] = counter++;
            }
        }

        static void FillColumnToTop(ref int[,] matrix, ref int counter, int column, int from, int to)
        {
            for (int i = from; i > to; i--)
            {
                matrix[i, column] = counter++;
            }
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
