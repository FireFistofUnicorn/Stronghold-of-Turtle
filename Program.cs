using System;

namespace CFN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {number}");
            int counter = 2;

            while (counter <= number - 1)
            {

                double remains = number % counter;
                if (remains == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Проздравляю, число {number} является простым");
                    break;
                }
            }
            counter++;
        }
    }
}
