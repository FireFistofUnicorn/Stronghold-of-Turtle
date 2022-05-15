using System;

namespace CheckFullNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {n}");
            
            int i = 1;
            while (i <= n - 1)
            {
                
                double c = n / i;
                bool g = c == 0;
                if (g)
                {

                    Console.WriteLine($"К сожалению, ваше число {n} не является простым.");
                    
                }
                else 
                {
                    Console.WriteLine($"Проздравляю, число {n} является простым");
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
