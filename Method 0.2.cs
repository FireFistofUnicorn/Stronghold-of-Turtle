using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathod_0._2
{
    internal class Program
    {
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

        static void Main(string[] args)
        {
            string test2 = Console.ReadLine();
            ReverseWord(args);
            Console.WriteLine(test2);
        }
        static string[] SplitWord2(string text)
        {
            string[] wordsSplit2 = text.Split(' ');
            ReverseWord(wordsSplit2);
            return wordsSplit2;
        }
        static string ReverseWord(string[] text)
        {
            Array.Reverse(text);
            string str = string.Join(" ", text);
            return str;
        }
    }
}
