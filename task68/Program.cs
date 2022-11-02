using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task68
{
    class Program
    {
        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.Даны два неотрицательных числа m и n.
        //m = 2, n = 3->A(m, n) = 9
        //m = 3, n = 2->A(m, n) = 29
        static void Main(string[] args)
        {
            int m = GetNumber("M");
            int n = GetNumber("N");
            if (m >= 0 && n >= 0)
            {
                int ack = Ackermann(m, n);
                Console.WriteLine($"результат = {ack}");
            }
            else
            {
                Console.WriteLine("некорректные числа");
            }
            Console.ReadLine();
        }
        static int GetNumber(string input)
        {
            Console.WriteLine($"Введите {input}");
            var value = Console.ReadLine();
            return Convert.ToInt32(value);
        }

        static int Ackermann(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            else
            {
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }
        }
    }
}
