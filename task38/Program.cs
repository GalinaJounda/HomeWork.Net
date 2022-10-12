using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task38
{
    class Program
    {
        //Задача 38: Задайте массив вещественных чисел.Найдите разницу между максимальным и минимальным элементов массива.
        //[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
        static void Main(string[] args)
        {
            var array = InitArray(1, 30, 6);
            var diff = GetMaximum(array) - GetMinimum(array);
            Console.WriteLine($"[{string.Join(", ", array)}] -> {diff}");
            Console.ReadLine();
        }

        static double[] InitArray(int min, int max, int size)
        {
            double[] array = new double[size];
            var rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(min, max) + rand.NextDouble();
                array[i] = Math.Round(array[i], 1);
            }
            return array;
        }

        static double GetMaximum(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        static double GetMinimum(double[] array)
        {
            double min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}

