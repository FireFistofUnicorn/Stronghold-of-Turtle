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
            //int input = Convert.ToInt32(Console.ReadLine());
            char key = 'д';
            do
            {
                Console.WriteLine("Введите номер телефона: ");
                long num = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Введите Фио: ");
                string name = Console.ReadLine();
                pairs.Add(num, name);
            } while (char.ToLower(key) == ' ');
            return;

            Console.WriteLine("Введите 1 для вводи новых данных / Введите 2 для поиска: ");


        }
    }
}
