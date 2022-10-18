using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<long, string> pairs = new Dictionary<long, string>();
            int i = 0;
            do
            {
                Console.WriteLine("Введите номер телефона: ");
                string num = Console.ReadLine();

                if (string.IsNullOrEmpty(num))
                {
                    Console.WriteLine("Вы закончили ввод.");
                    break;
                }

                    Console.WriteLine("Введите Фио: ");
                    string name = Console.ReadLine();
                    long number = Convert.ToInt64(num);
                    pairs.Add(number, name);
                i++;
            } while (i > 0);
            

            Console.WriteLine("Для поиска владельца, введите его номер теелфона: ");
            long n = Convert.ToInt64(Console.ReadLine());

            foreach(var key in pairs)
            {
                if(key.Key == n)
                {
                    Console.WriteLine(key.Value);
                }
                else if( key.Key != n)
                {
                    Console.WriteLine("404");
                }    
                
            }
            Console.ReadKey();
        }
    }
}