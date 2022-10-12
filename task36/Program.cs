using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task36
{
    class Program
    {
        //Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
        //[3, 7, 23, 12] -> 19
        //[-4, -6, 89, 6] -> 0
        static void Main(string[] args)
        {
            var array = InitArray(-10, 10, 6);
            var sum = SumtOddPositions(array);
            Console.WriteLine($"[{string.Join(", ", array)}] -> {sum}");
            Console.ReadLine();
        }

        static int[] InitArray(int min, int max, int size)
        {
            int[] array = new int[size];
            var rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(min, max);
            }
            return array;
        }
        static int SumtOddPositions(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + array[i];
                }
            }
            return sum;
        }
    }
}
