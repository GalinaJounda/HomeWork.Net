using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task41
{
    class Program
    {
        //Задача 41: Пользователь вводит с клавиатуры M чисел.Посчитайте, сколько чисел больше 0 ввёл пользователь.
        //0, 7, 8, -2, -2 -> 2
        //-1, -7, 567, 89, 223-> 3
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько чисел через запятую");
            var numbers = GetNumbers();
            ShowResult(numbers);
            Console.ReadLine();
        }

        static int[] GetNumbers()
        {
            var value = Console.ReadLine();
            var strings = value.Split(new string[] { ", ", "," }, StringSplitOptions.RemoveEmptyEntries);
            var numbers = new int[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                numbers[i] = Convert.ToInt32(strings[i]);
            }
            return numbers;
        }

        static void ShowResult(int[] numbers)
        {
            var result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i] > 0 ? 1 : 0;
            }

            Console.WriteLine($"{string.Join(", ", numbers)} -> {result}");
        }
    }
}
