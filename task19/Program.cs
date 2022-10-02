using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19
{
    class Program
    {
        //Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        //14212 -> нет
        //12821 -> да
        //23432 -> да
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 10000 || num > 99999)
            {
                Console.WriteLine("Число не пятизначное");
            }

            Console.WriteLine(num / 10000 == num % 10 && num % 10000 / 1000 == num % 100 / 10 ? "да" : "нет");
            
            Console.ReadLine();
        }
    }
}
