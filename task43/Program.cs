using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task43
{
    class Program
    {
        //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
        //заданных уравнениями y = k1* x + b1, y = k2* x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        //b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
        static void Main(string[] args)
        {
            var k1 = GetNumber("k1");
            var b1 = GetNumber("b1");
            var k2 = GetNumber("k2");
            var b2 = GetNumber("b2");

            ShowIntersection(k1, b1, k2, b2);
            Console.ReadLine();
        }

        static int GetNumber(string input)
        {
            Console.WriteLine($"Введите переменную {input}");
            var value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        static void ShowIntersection(double k1, double b1, double k2, double b2)
        {
            var x = (b2 - b1) / (k1 - k2);
            var y = k1 * x + b1;
            Console.WriteLine($"({x}, {y})");
        }
    }
}
