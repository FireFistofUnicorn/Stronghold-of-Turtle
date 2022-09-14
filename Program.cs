using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Repository10 rep = new Repository10(string.Empty);

            Console.WriteLine("Для просмотра всех записей введите '0'");
            Console.WriteLine("Чтобы найти конкретного сотрудника введите '1' / Чтобы добавить сотрудника введите '2'");
            Console.WriteLine("Для создания записи введите '3' / Для удаления сотрудника введите '4'");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 0)
            {
                rep.GetAllWorkers(args);
                Console.WriteLine();
            }
            else if (input == 1)
            {
                rep.GetWorkerById();
            }
            else
            if (input == 2)
            {
                rep.Add(new Worker());
            }
        }
    }
}
