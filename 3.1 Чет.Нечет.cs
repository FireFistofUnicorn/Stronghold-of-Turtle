
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Вы ввели чётное число");

            }
            else
            {
                Console.WriteLine("Вы ввели нечётное число");
            }

            Console.WriteLine();
        }
    }
}