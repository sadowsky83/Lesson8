using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    internal class Program
    {
        // Создание файла с числами и вывод их суммы
        static void Main(string[] args)
        {
            StreamWriter anyFileWrite = new StreamWriter("c:\\any directory\\any file.txt");
            Random randomNum = new Random();
            for (int i = 0; i < 10; i++) anyFileWrite.WriteLine(randomNum.Next(0, 10));
            anyFileWrite.Close();

            StreamReader anyFileRead = new StreamReader("c:\\any directory\\any file.txt");
            string numbersInFile = null;
            int sum = 0;

            while ((numbersInFile = anyFileRead.ReadLine()) != null)
            {
                sum += int.Parse(numbersInFile);
            }

            anyFileRead.Close();
            Console.WriteLine("Сумма чисел в файле равна " + sum);
            Console.ReadKey();
        }
    }
}
