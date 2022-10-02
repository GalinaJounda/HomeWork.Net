using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    class Program
    {
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                num = -num;
            }

            int sum = 0;
            while (num > 0)
            {
                sum = num % 10 + sum;
                num = num / 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
