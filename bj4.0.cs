using System;

namespace BJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую вас! Введите свое количество карт");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= a; ++i)
            {
                Console.WriteLine($"Введите номинал {i}-й карты");
                string c = Console.ReadLine();

                switch (c)
                {
                    case "0":
                        sum += 0;
                        break;

                    case "1":
                        sum += 1;
                        break;

                    case "2":
                        sum += 2;
                        break;

                    case "3":
                        sum += 3;
                        break;

                    case "4":
                        sum += 4;
                        break;

                    case "5":
                        sum += 5;
                        break;

                    case "6":
                        sum += 6;
                        break;

                    case "7":
                        sum += 7;
                        break;

                    case "8":
                        sum += 8;
                        break;

                    case "9":
                        sum += 9;
                        break;

                    case "10":
                        sum += 10;
                        break;

                    case "J":
                        sum += 10;
                        break;

                    case "Q":
                        sum += 10;
                        break;

                    case "K":
                        sum += 10;
                        break;

                    case "T":
                        sum += 10;
                        break;

                }

            }

            Console.WriteLine($"Сумма всех ваших карт = {sum}");
        }
    }
}
