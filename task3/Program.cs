using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    internal class Program
    {
        // Статистика по файлу
        static void Main(string[] args)
        {
            StreamReader anyFileRead = new StreamReader("c:\\any directory\\text.txt");
            string text = System.IO.File.ReadAllText("c:\\any directory\\text.txt");
            int sumOfSymbols = text.Replace(" ","").Length;
            int sumOfLines = System.IO.File.ReadAllLines("c:\\any directory\\text.txt").Length;
            int sumOfWords = (text.Split(' ')).Length;            

            anyFileRead.Close();

            Console.WriteLine("Количество символов в тесте " + sumOfSymbols);
            Console.WriteLine();
            Console.WriteLine("Количество строк в тексте " + sumOfLines);
            Console.WriteLine();
            Console.WriteLine("Количество слов в тексте  " + sumOfWords);
            Console.ReadKey();
        }
    }
}
