using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Potok_0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите <1> чтобы вывести данные на экран / Введите <2> чтобы заполнить данные: ");
            char input = Convert.ToChar(Console.ReadLine());
            if (input == '2')
            {
                Word(args);
                Console.WriteLine();
            }
            else if (input == '1')
            {
                using (StreamReader sr = new StreamReader("Unicode1.txt", Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split('\t');
                        Console.WriteLine($"{words[0],0}");
                    }
                }
            }
        }
        static void Word(string[] text)
        {
            using (StreamWriter sw = new StreamWriter("Unicode1.txt", true, Encoding.UTF8))
            {
                char key = 'д';
                do
                {
                    string note = string.Empty;
                    Console.WriteLine("/Введите ID: ");
                    note += $"{Console.ReadLine()} ";

                    string now = DateTime.Now.ToShortDateString();
                    Console.WriteLine($"/Дата и время добавления записи: {now} ");
                    note += $"{now} ";

                    string name = string.Empty;
                    Console.WriteLine("Введите Ф.И.О.: ");
                    note += $"{Console.ReadLine()} ";

                    string old = string.Empty;
                    Console.WriteLine("Введите возраст: ");
                    note += $"{Console.ReadLine()} ";

                    string Long = string.Empty;
                    Console.WriteLine("Введите рост: ");

                    note += $"{Console.ReadLine()} ";

                    string data = string.Empty;
                    Console.WriteLine("Введите дату рождения: ");
                    note += $"{Console.ReadLine()} ";

                    string place = string.Empty;
                    Console.WriteLine("Введите место рождения: ");
                    note += $"{Console.ReadLine()} ";

                    sw.WriteLine(note);
                    Console.WriteLine("Продолжить н/д:");
                    key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == 'д');


            }
            return;
        }
    }
}