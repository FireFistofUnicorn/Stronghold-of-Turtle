using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую вас! Введите свое количество карт");
            int a = int.Parse(Console.ReadLine());
            int b = 0;
           
            for (int i = 1; i <= a; ++i)
            {
                Console.WriteLine($"Введите номинал {i}-й карты");
                int c = Convert.ToInt32(Console.ReadLine());
                
                switch (c)
                {

                    case 'J':
                        
                        c += 10;
                        
                        break;

                    case 'Q':
                        c += 10;
                        break;

                    case 'K':
                        c += 10;
                        break;

                    case 'T':
                        c += 10;
                        break;

                }
                int d = Convert.ToInt32(c);
                b += d;

            }
            
            Console.WriteLine($"Сумма всех ваших карт = {b}");
        }
    }
}
