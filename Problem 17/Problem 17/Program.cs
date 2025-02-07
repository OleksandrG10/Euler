using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Problem_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch c = Stopwatch.StartNew();
            int count = 0;
            //шях до файлу з символами
            string filePath = @"e:\Проекти\Project Euler\Problem 17\Letters.txt";// Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Letters.txt";           
            
            //читаємо з файла в рядок
            string words = System.IO.File.ReadAllText(filePath);
            
            //читаємо з рядка в строковий масив, видаляючи при цьому пробіли і коми
            string[] w = words.Replace(" ", "").Split(',');

            foreach (string s in w)
            {                
                for (int i = 0; i < s.Length; i++)
                {
                    count++;
                }
            }
            c.Stop();
            Console.Write("Count letters = {0}", count);
            Console.Write("\nRun time programming {0}", c.ElapsedMilliseconds);
            Console.ReadLine();
        }        
    }
}