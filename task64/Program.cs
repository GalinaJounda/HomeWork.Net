using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task64
{
    class Program
    {
        //Задача 64: Задайте значение N.Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
        //Выполнить с помощью рекурсии.
        //N = 5 -> "5, 4, 3, 2, 1"
        //N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"
        static void Main(string[] args)
        {
            int number = GetNumber("число");
            NaturalNumbersRevers(number);
            Console.ReadLine();
        }

        static int GetNumber(string input)
        {
            Console.WriteLine($"Введите {input}");
            var value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        static void NaturalNumbersRevers(int num)
        {
            if (num == 0)
            {
                return;
            }

            if (num == 1)
            {
                Console.Write($"{num}");
            }
            else {
                Console.Write($"{num}, ");
            }

            NaturalNumbersRevers(num - 1);
        }
    }
}
