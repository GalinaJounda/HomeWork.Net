using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task34
{
    class Program
    {
        //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
        //Напишите программу, которая покажет количество чётных чисел в массиве.
        //[345, 897, 568, 234] -> 2
        static void Main(string[] args)
        {
            var array = InitArray(100, 999, 4);
            var count = CountEvenNumbers (array);
            Console.WriteLine($"[{string.Join(", ", array)}] -> {count}");
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

        static int CountEvenNumbers(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 ==0)
                {
                    count++;
                }
            }
            return count;
        }
        
    }
}
//Console.WriteLine("введите число");
//            int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(a % 2 == 0 ? "да" : "нет");