using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Problem_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch c = Stopwatch.StartNew();
            //Шлях до текстового файлу з данними
            string filePath = @"f:\Проекти\Project Euler\Problem 22\names.txt";

            //Читаємо з файла в рядок
            string words = System.IO.File.ReadAllText(filePath);

            //Читаємо з рядка в масив, при цьому видаляючи (\") лапки і коми
            string[] word = words.Replace("\"", "").Split(',');

            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
                                  'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            
            //сортуємо  масив
            SortArray(word);

            //позиція слова у файлі
            int positionWord = 0;

            //позиція літери в слові
            int positionLetter = 0;

            //Сума літер
            int sumLetters = 0;
            
            //Сума балів слова
            int sumPoints = 0;

            //Загальна кількість балів у файлі
            int result = 0;

            StreamWriter sw = new StreamWriter("output.txt", false, System.Text.Encoding.ASCII);
            foreach (var w in word)
            {                
                positionWord++;
                foreach (var l in w)
                {
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        if (l == alphabet[i])
                        {
                            positionLetter = i;
                            sumLetters += positionLetter + 1;
                            break;
                        }
                    }                    
                }
                sumPoints = sumLetters * positionWord;
                result += sumPoints;

                // Обнуляємо суму літер
                sumLetters = 0;               
            }

            sw.Close();
            c.Stop();
            Console.WriteLine("\nThe total of all the name scores in the file {0}", result);
            Console.WriteLine("The time run programm {0} ms", c.ElapsedMilliseconds);
            Console.ReadLine();                
        }
        
        static void SortArray(string[] array)
        {
            string temp = string.Empty;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        } 
    }
}
