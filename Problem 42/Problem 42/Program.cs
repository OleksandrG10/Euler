using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Problem_42
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch c = Stopwatch.StartNew();

            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                  'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            int[] tn = { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, 66, 78, 91, 105, 120, 136, 153,
                         171, 190, 210, 231, 253, 276, 300, 325, 351 };

            List<string> triangleWords = new List<string>();

            int positionLetter = 0;
            int sumLetter = 0;
            string line = string.Empty;
            string[] words;

            try
            {
                using (StreamReader sr = new StreamReader("words.txt"))
                {
                    line = sr.ReadToEnd();
                }

                words = line.Replace("\"", "").Split(',');
                foreach (var word in words)
                {
                    foreach (var letter in word)
                    {
                        for(int i = 0; i <alphabet.Length; i++)
                        {
                            if (letter == alphabet[i])
                            {
                                positionLetter = i;
                                sumLetter += positionLetter + 1;
                                break;
                            }
                        }
                    }

                    for (int j = 0; j < tn.Length; j++)
                    {
                        if (sumLetter == tn[j])
                        {
                            triangleWords.Add(word);
                            break;
                        }
                    }
                    sumLetter = 0;
                }
             
                foreach (var w in triangleWords)
                {
                    Console.Write(w.ToString() + " ");
                }
                Console.WriteLine("\n\nThe number of triangle words = {0}", triangleWords.Count);

            }
            catch(Exception e)
            {                
                Console.WriteLine(e.Message);
            }
            c.Stop();
            Console.WriteLine("\nTime ia running program {0}", c.ElapsedMilliseconds);
            Console.ReadKey();
        }


    }
}
