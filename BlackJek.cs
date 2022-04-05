using System;

namespace BlackJek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую вас! Введите свое количество карт");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;

            for (int i = 1; i <= a; ++i)
            {
                Console.WriteLine($"Введите номинал {i}-й карты");
                char c = Convert.ToChar(Console.ReadLine());
                int d = Convert.ToInt32(c);
                if (c == 'J')
                {
                    d = 10;
                }
                else
                    if (c == 'Q')
                {
                    d = 10;
                }
                else
                        if (c == 'K')
                {
                    d = 10;
                }
                else
                        if (c == 'T')
                {
                    d = 10;
                }
                b += c;
                
            }
            Console.WriteLine($"Сумма всех ваших карт = {b}");
        }
    }
}
