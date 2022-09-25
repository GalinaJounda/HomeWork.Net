using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    class Program
    {
        //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
        //и проверяет, является ли этот день выходным.
        //6 -> да
        //7 -> да
        //1 -> нет
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            if (number <= 5 && number >= 1)
            {
                Console.WriteLine("нет");
            }

            if (number >= 6 && number <= 7)
            {
                Console.WriteLine("да");
            }
            Console.ReadLine();
        }
    }
}
