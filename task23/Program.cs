using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task23
{
    class Program
    {
        //Задача 23. Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.
        //3 -> 1, 8, 27
        //5 -> 1, 8, 27, 64, 125
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            TableCube(num);
            Console.ReadLine();
        }

        static void TableCube(int arg)
        {
            int i = 1;
            if (arg > 0)
            {
                while (i <= arg)
                {
                    Console.WriteLine($"{i} {Math.Pow(i, 3)}");
                    i++;
                }
            }
        }
    }
}
