using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    internal class Program
    {
        // Содержание любой папки
        static void Main(string[] args)
        {
            string dirName = "C:\\Any directory";

            OutputFolderContents(dirName);

            Console.ReadKey();
        }

        static void OutputFolderContents(string dirName)
        {
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Содержимое директории " + dirName + " папки:");
                string[] dirString = Directory.GetDirectories(dirName);
                foreach (string s in dirString)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Содержимое директории " + dirName + " файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine();

                if (dirString.Length != 0)
                {
                    foreach (string s in dirString)
                    {
                        OutputFolderContents(s);
                    }
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Папка не найдена");
            }
        }
    }
}
