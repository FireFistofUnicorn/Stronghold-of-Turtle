using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ф. И. О.: ");
            string FulName = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Email: ");
            string mail = Console.ReadLine();

            Console.WriteLine("Введите баллы по программированию: ");
            double pr = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите баллы по математике: ");
            double math = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите баллы по физике: ");
            double phys = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Идет подсчет результатов...");

            double a = pr + math + phys;
            double b = a / 3;

            Console.WriteLine("Нажмите Enter для вывода результата");
            Console.ReadKey();
            Console.WriteLine(b);


            Console.WriteLine();
        }
    }
}
