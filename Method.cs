using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main()
        {

            static string[] WordsSplitter(string text)
            {
                string[] wordsSplit = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string word = Console.ReadLine();
                string[] words = new string[text.Length];
                return words;


                static void Main(string[] args)
                {
                    WordsSplitter(Console.ReadLine());
                    foreach (char item in Console.ReadLine())
                    {
                        string[] wordd = new string[args.Length];
                    }

                    return;
                }
            }
        }
    }
}

            /*static string[] WordsSplitter(string text)
            {
                string[] wordsSplit = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string word = Console.ReadLine();
                foreach (char item in word)
                {
                    string[] words = new string[text.Length];
                }
                return wordsSplit;

            }

            static void Main(string[] args)
            {
                WordsSplitter(Console.ReadLine());
            */

