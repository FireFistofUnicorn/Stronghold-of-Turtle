using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Введите количество строк: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int[,] a = new int[row, col];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            { 
                for (int j = 0; j < col; j++)
                {
                    a[i,j] = r.Next(10);
                    Console.Write($"{a[i, j]} ");
                    
                    for(int d = 0; d < 1; d++)
                    {
                        sum = sum + a[i,j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов этой матрицы: {sum}");





            Console.WriteLine($"Введите длину последовательности:");
            int elementsCount = Convert.ToInt32(Console.ReadLine());
            int [] myArray = new int[elementsCount];
            int minValue = myArray[0];
            
            for (int i = 0;  i < myArray.Length; i++)
            {
                Console.WriteLine($"\nВведите элемент массива под индексом {i}:\t ");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
               
            }

            Console.WriteLine("\nВывод массива:\t");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            for(int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }

            }
            Console.WriteLine($"Минимальное значение массива: {minValue}");
            Console.WriteLine();*/






            Console.WriteLine("Введите максимальное целое число диапазона: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            Random rand = new Random();
            int num = rand.Next(0, number);
            int userNumber;
            Console.WriteLine(num);
            string f = Console.ReadLine();
            for (; ; )
            {
                Console.WriteLine("Введите предпологаемое число: ");
                count++;
                userNumber = Convert.ToInt32(Console.ReadLine());
                if(userNumber < num)
                {
                    Console.WriteLine("Ваше число МЕНЬШЕ загаданного.");
                }else
                    if(userNumber > num)
                 {
                    Console.WriteLine("Ваше число БОЛЬШЕ загаданного.");
                 }else
                    if (userNumber == num)
                  {
                    Console.WriteLine($"Поздравляю. вы отгадали число! Число попыток : {count}");
                    break;
                  }
                if (f == string.Empty)
                {
                    Console.WriteLine($"Очень жаль что вы сдались так рано, загаданное число было {num}");
                }




                Console.WriteLine();
            }
            
            
        }
    }
}
