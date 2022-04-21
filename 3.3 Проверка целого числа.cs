using System;

namespace Проверка_простого_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {a}");

            int c = 0;
            while (c <= a)
            {
                Console.WriteLine($"{a}");
                if (a % 2 == 0 && a != 2)
                {
                    Console.WriteLine("К сожалению, ваше число не является простым.");
                }
                else if (a % Math.Sqrt (a) == 0)
                {
                    Console.WriteLine($"К сожалению, ваше число не является простым.");
                }
                else if (a % a == 0 && a % 1 == 0)
                {
                    Console.WriteLine($"Число {a} является простым.");
                }
                break;

            }
            
        }
    }
}