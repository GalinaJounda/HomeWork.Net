using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task25
{
    class Program
    {
        //Задача 25: Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.
        //3, 5 -> 243 (3⁵)
        //2, 4 -> 16
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Pow(a, b));
            Console.ReadLine();
        }
    }
}
