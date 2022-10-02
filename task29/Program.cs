using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task29
{
    class Program
    {
        //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
        //1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
        static void Main(string[] args)
        {
            int[] array = new int[8];
            var rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 99);
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
            Console.ReadLine();
        }
    }
}
