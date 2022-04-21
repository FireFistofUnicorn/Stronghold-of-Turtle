using System;

namespace AAAAAA
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
                string c = Console.ReadLine();

                if (c == "J")
                {
                    int h = 10;
                    b += h;
                }
                else
                if (c == "Q")
                {
                    int h = 10;
                    b += h;
                }
                else
                if (c == "K")
                {
                    int h = 10;
                    b += h;
                }
                else
                if (c == "T")
                {
                    int h = 10;
                    b += h;
                }
                else
                {
                    string j = Convert.ToString(c);
                    int k = Convert.ToInt32(j);
                    b += k;
                }

               




            }
            
            Console.WriteLine($"Сумма всех ваших карт = {b}");
        }
    }
}
