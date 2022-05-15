using System;

namespace CFN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {n}");
            int i = 2;
            bool g = n % i == 0;

            while (i <= n - 1)
            {


                if (g == true)
                {

                    Console.WriteLine($"К сожалению, ваше число {n} не является простым.");
                }
                else if (g == false)
                {
                    Console.WriteLine($"Проздравляю, число {n} является простым");
                }
                break;

            }
        }
    }
}
