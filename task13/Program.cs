using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        //645 -> 5
        //78 -> третьей цифры нет
        //32679 -> 6
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            double a = Math.Log10(number);      //логарифм по 10
            double b = Math.Floor(a);           //количество цифр -1

            if (b < 2)
            {
                Console.WriteLine("третьей цифры нет");
            }
            else
            {
                double c = Math.Pow(10, b - 1);
                double d = number % c;              //отбрасываем первые две цифры
                int e = (int)d / (int)(c / 10);

                Console.WriteLine(e);
            }
            
            Console.ReadLine();
        }
    }
}
