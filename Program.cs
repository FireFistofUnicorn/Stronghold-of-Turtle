using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_1._0
{
    internal class Program
    {
        // Задание 1. Метод разделения строки на слова

        /*static void Main(string[] args)
        {
            Words(args);
            Console.WriteLine();
        }
        static string[] WordsSplitter(string text)
        {
            string[] wordsSplit = text.Split(' ');
            return wordsSplit;
        }

        static string Words(string[] args)
        {
            string word = Console.ReadLine();
            string[] words = WordsSplitter(word);
            foreach (string word2 in words)
            {
                word = word2.Trim();
                Console.WriteLine(word);
            }
            return word;
        }*/

        // Задание 2. Перестановка слов в предложении
        static string ReverseWord(string[] args)
        {
            string word = Console.ReadLine();
            string[] sReverse = SplitWord2(word);
            Array.Reverse(sReverse);
            SplitWord2(word);
            foreach (string word2 in sReverse)
            {
                word = word2.Trim();
                Console.Write(word + " ");
            }
            return word;
        }
        static string[] SplitWord2(string text)
        {

            string[] wordsSplit2 = text.Split(' ');
            return wordsSplit2;
        }
        static void Main(string[] args)
        {
            ReverseWord(args);
            Console.WriteLine();
        }
    }
}
