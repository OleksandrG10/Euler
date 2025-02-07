using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Problem_89
{
    class Program
    {        
        static void Main(string[] args)
        {
            Stopwatch c = Stopwatch.StartNew();
            try
            {                              
                string filePath = @"e:\Проекти\Project Euler\Problem 89\roman.txt";                
                string roman = File.ReadAllText(filePath);
                string pattern = "DCCCC|LXXXX|VIIII|CCCC|XXXX|IIII";
                string replacement = "kk";                
                int result = roman.Length - Regex.Replace(roman, pattern, replacement).Length; ;               
                Console.WriteLine("Result = {0}", result);
                Console.ReadLine();
            }
            catch (FileNotFoundException fex)
            {
                Console.WriteLine();
                Console.WriteLine(fex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }            
        }                
    }
}
