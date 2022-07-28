using System;

namespace mASS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
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
                    a[i, j] = r.Next(-10, 10);
                    sum = sum + a[i, j];
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов этой матрицы: {sum}");

            int[,] b = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    b[i, j] = r.Next(-10, 10);
                    Console.Write($"{b[i, j]} ");
                }
                Console.WriteLine();
            }
            int[,] c = new int[row, col];
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.Write($"{c[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
