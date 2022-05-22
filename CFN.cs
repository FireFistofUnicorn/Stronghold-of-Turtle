using System;

namespace CFN2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 2;
            bool flag = false;

            while(counter <= number - 1)
            {
               int remains = number % counter;
               if(remains == 0)
               {
                    flag = true;
                    break;
               }
                counter++;

            }

            if (flag)
            {
                Console.WriteLine($"Число {number} не является простым.");
            }
            else
            {
                Console.WriteLine($"Поздравляю, число {number} является простым!");
            }
        }
    }
}
