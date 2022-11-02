using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task66
{
    class Program
    {
        //Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        //M = 1; N = 15 -> 120
        //M = 4; N = 8. -> 30
        static void Main(string[] args)
        {
            int m = GetNumber("M");
            int n = GetNumber("N");
            int sum = SumNatureNumbers(m, n);
            Console.WriteLine($"сумма = {sum}");
            Console.ReadLine();
        }

        static int GetNumber(string input)
        {
            Console.WriteLine($"Введите {input}");
            var value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        static int SumNatureNumbers(int m, int n)
        {
            if (m == n)
            {
                return m;
            }
            else if (m > n)
            {
                return n + SumNatureNumbers(m, n + 1);
            }
            else
            {
                return m + SumNatureNumbers(m + 1, n);
            }
        }
    }
}
