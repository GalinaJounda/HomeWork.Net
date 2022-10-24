//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace test2
//{
//    class Class2
//    {
//        static void Task2()
//        {
//        Console.WriteLine("Введите координаты точки");
//            Console.Write("X: ");
//            int x = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Y: ");
//            int y = Convert.ToInt32(Console.ReadLine());

//        int quarter = Quarter(x, y);
//        string result = quarter > 0 ? $"Указанные координаты соответствуют четверти -> {quarter.ToString()}"
//                                      : "Введенны некорректные координаты";
//            Console.WriteLine(result); 
//        }  int Quarter (int xc, yc)
//            {
//            if(xc > 0 && yc > 0) return 1;
//            if(xc > 0 && yc > 0) return 2;
//            if(xc > 0 && yc > 0) return 3;
//            if(xc > 0 && yc > 0) return 4;
//            return 0;
//            }


////Задача 20: Напишите программу, которая
////принимает на вход координаты двух точек и
////находит расстояние между ними в 2D пространстве.
////A(3,6); B(2,1) -> 5,09
////A(7,-5); B(1,-1) -> 7,21
//double Gipotinuse(double xa, double ya, double xb, double yb)
//        {
//            double result = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2));
//            result = Math.Round(result, 2, MidpointRounding.ToZero);
//            return result;
//        }
//    static void Task2()
//        { 
//        Console.Write("Первая точка - введите координату x: ");
//        int x1 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Первая точка - введите координату y: ");
//        int y1 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Вторая точка - введите координату x: ");
//        int x2 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Вторая точка - введите координату y: ");
//        int y2 = Convert.ToInt32(Console.ReadLine());

//        double distance = Gipotinuse(x1, y1, x2, y2);
//        Console.Write($"Расстояние между точками {x1},{y1} и {x2},{y2} - {distance}");


//        {   //Код округления
//            double num = 3.09987565; // 3.09
//            double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
//            System.Console.WriteLine(numRound);

//        }
//        //Задача 22: Напишите программу, которая принимает на вход число(N) и 
//        //выдаёт таблицу квадратов чисел от 1 до N.
//        //5 -> 1, 4, 9, 16, 25.
//        //2 -> 1,4
//}
//Задача 39: Напишите программу, которая перевернёт
//одномерный массив(последний элемент будет на первом
//месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
static void Task2()

    void ReverseArray(int[] array){    int size = array.Length; // 5
    int index1 = 0;    int index2 = size - 1;
    //  0 1 2 3 4      0 1 2 3 4
    // [1 2 3 4 5] -> [5 4 3 2 1]
    while (index1 < index2)    {        int obj = array[index1]; //2
        array[index1] = array[index2]; //2 -> 4
        array[index2] = obj; // 2

        index1++;        index2--;    }    void ReverseArray2(int[] array)
    {
        int size = array.Length; // 5
        for (int i = 0; i < size / 2; i++)
        {
            int obj = array[i];
            array[i] = array[size - 1 - i];
            array[size - 1 - i] = obj;
        }
    }
}
//Задача 40: Напишите программу, которая принимает на вход три
//числа и проверяет, может ли существовать треугольник с сторонами
//такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон.
void ReverseArray(int[] array)
{ 
    Console.WriteLine("Введите длину 1-й стороны: ");    int numb1 = Convert.ToInt32(Console.ReadLine());    Console.WriteLine("Введите длину 2-й стороны: ");    int numb2 = Convert.ToInt32(Console.ReadLine());    Console.WriteLine("Введите длину 3-й стороны: ");    int numb3 = Convert.ToInt32(Console.ReadLine());    bool TriangleExists(int num1, int num2, int num3)    {        return (num1 < num2 + num3) && (num2 < num1 + num3) && (num3 < num1 + num2);    }    if (TriangleExists (numb1, numb2, numb3)) Console.WriteLine($"Треугольник с такими сторонами может существовать");    else Console.WriteLine("Треугольник с такими сторонами существовать не может");
}


//Задача 42: Напишите программу, которая будет преобразовывать//десятичное число в двоичное.//45 -> 101101//3 -> 11//2 -> 10
void ReverseArray(int[] array)
{
Console.Write("Введите число: ");int num = Convert.ToInt32(Console.ReadLine());string ConvertBinNum(int n){    string res = default;    while (n != 0)    {        res += (n % 2).ToString();        n /= 2;    }    char[] arr = res.ToCharArray();    Array.Reverse(arr);    return new string(arr);}
    int number = 13;
    ConvertToBin2(int num);System.Console.WriteLine(ConvertBinNum(num));

    void ConvertToBin2(int num)
    {
        
        if (num == 0) return;
        ConvertToBin2(num / 2);
        Console.Write(num % 2);
    }
    ConvertToBin2(int num);

}
//Задача 44: Не используя рекурсию, выведите первые N чисел
//Фибоначчи.Первые два числа Фибоначчи: 0 и 1.
//Если N = 5-> 0 1 1 2 3
//Если N = 3-> 0 1 1
//Если N = 7-> 0 1 1 2 3 5 8

//double Fibonachi(double n)//{//    if (n == 1 || n == 2) return 1;//    else return Fibonachi(n - 1) + Fibonachi(n - 2);
//}//for (double i = 1; i <= 10; i++)//{//    System.Console.WriteLine($"f{i}) = {Fibonachi(i)}");

Console.Write("Введите целое положительное число:");int numA = Convert.ToInt32(Console.ReadLine());void Fibonacci(int num){    int num1 = 0;    int num2 = 1;    int num3 = default;    Console.Write($"N = {numA} -> {num1} {num2}");    for (int i = 2; i < num; i++)    {        num3 = num1 + num2;        Console.Write($" {num3}");        num1 = num2;        num2 = num3;
    }
    Fibonacci(numA);
}
//    }
//Задача 44: Не используя рекурсию, выведите первые N чисел//Фибоначчи.Первые два числа Фибоначчи: 0 и 1.//Если N = 5-> 0 1 1 2 3//Если N = 3-> 0 1 1//Если N = 7-> 0 1 1 2 3 5 8
int[] arr = CreateArrayRndInt(5, 1, 8);PrintArray(arr);int[] arr2 = CopyArray(arr);arr2[0] = 100;PrintArray(arr2);int[] CopyArray(int[] array){    int[] arrayCopy = new int[array.Length];    for (int i = 0; i < array.Length; i++)    {        arrayCopy[i] = array[i];
    }    return arrayCopy;}int[] CreateArrayRndInt(int size, int min, int max){    int[] array = new int[size];    var rnd = new Random();    for (int i = 0; i < size; i++)    {        array[i] = rnd.Next(min, max + 1);    }    return array;}void PrintArray(int[] array){    Console.Write("[");    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");    Console.Write($"{array[array.Length - 1]}]");}

//}
