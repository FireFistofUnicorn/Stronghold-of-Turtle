using System;

namespace BlackJeck2._0
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
                string c = Console.ReadLine();
                
                switch (c)
                {
                    case "0":
                        b += 0;
                        break;

                    case "1":
                        b += 1;
                        break;

                    case "2":
                        b += 2;
                        break;

                    case "3":
                        b += 3;
                        break;

                    case "4":
                        b += 4;
                        break;

                    case "5":
                        b += 5;
                        break;

                    case "J":
                        b += 10;
                        break;

                }
                b += c;

            }
            
            Console.WriteLine($"Сумма всех ваших карт = {b}");
        }
    }
}
