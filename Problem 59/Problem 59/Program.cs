using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_59
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch c = Stopwatch.StartNew();

            //file
            string pathFile = "p059_cipher.txt";

            //read file
            string lines = System.IO.File.ReadAllText(pathFile);

            //
            string[] keys = lines.Replace(" ", "").Split(',');
            List<int> arrayKey = new List<int>();
            List<int> array = new List<int>();
            
            //for (int i = 0; i < keys.Length; i++)
            //{  
            //    int key = Convert.ToInt32(keys[i]);                
            //    arrayKey.Add(key);
            //    if (arrayKey.Count == 3)
            //    {
            //        int n = 0;

            //        for (int k = 0; k < arrayKey.Count; k++)
            //        {
            //            n ^= arrayKey[k];
            //        }
            //        array.Add(n);
            //        arrayKey.RemoveRange(0, 3);
            //    }
               
            //}

            //char character = ' ';
            //int sum = 0;
            //foreach (int n in array)
            //{
            //    character = Convert.ToChar(n);                
            //    Console.Write((char)character);
            //    sum += n;
            //}
            //Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
