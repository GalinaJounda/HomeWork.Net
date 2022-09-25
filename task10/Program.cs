using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        //456 -> 5
        //782 -> 8
        //918 -> 1
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            int a = number % 100; // две последние цифры
            int b = a / 10; //целочисленное деление

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
