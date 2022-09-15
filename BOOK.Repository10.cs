using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Book
{
    class Repository10
    {
        private Worker[] workers;
        public string path;

        int index;
        string[] titles;
        public Repository10(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.titles = new string[7];
            this.workers = new Worker[2];
        }

        public void AddW(int Position)// Позиция нужного элемента
        {
            for (int i = Position; i < this.index; i++)
            {
                this.titles[i] = this.titles[i + 1];
            }
            this.index--;
        }
        public string Print(string Text = " ") // Печать
        {
            string output = string.Empty;
            for (int i = 0; i < this.index; i++) output += $"{this.titles[i]} ";
            return $"{Text} {output}".Trim();
        }

        public void GetAllWorkers(string[] args)// ПРОСМОТР ВСЕХ ЗАПИСЕЙ
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

        public void Add(Worker ConcreteWorker) // ДОБАВИТЬ НОВОГО СОТРУДНИКА
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
                return;
            }
        }

        public void GetWorkerById(params Worker[] Args) //ВЫЧИСЛИТЬ ПО ID
        {
            Console.Write("Введите Id искомого сотрудника:");
            string target = Console.ReadLine();
            string[] readText = File.ReadAllLines(@"Unicode1.txt");
            int count = readText.Count();

            for (int i = 0; i < target.Length; i++)
            {
                int temp = int.Parse(target);
                if (temp < count && temp > 0)
                    Console.WriteLine("Строка номер {0} : {1}", temp, readText[i]);
                else Console.WriteLine("Строки номер {0} нет", temp);
                
            }
            Console.ReadKey();
        }
        
    }
}