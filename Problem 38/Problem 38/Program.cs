using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch c = Stopwatch.StartNew();
            try
            {
                string strNumber;
                int n = 1;                
                Dictionary<int, string> myDictionary = new Dictionary<int, string>();
                Regex rx = new Regex("(?!.*([1-9]).*\\1)^[1-9]{9}$");
                Match match;
                int maxPanDigit = 1;
                int panDigit = 0;

                while (n < 10000)
                {
                    strNumber = string.Empty;
                    
                    for (int i = 1; i <= 9; i++)
                    {
                        strNumber += n * i;
                        match = rx.Match(strNumber);

                        if (match.Success)
                        {
                            myDictionary.Add(n, strNumber);
                            panDigit = int.Parse(strNumber);
                            break;
                        }
                    }
                    
                    if (panDigit > maxPanDigit)
                        maxPanDigit = panDigit;
                    n++;
                }

                Console.WriteLine("The largest 1 to 9 pandigital 9-digit number = {0}", maxPanDigit);
                //foreach (var pair in myDictionary)
                //{
                //    Console.WriteLine("{0} - {1} ", pair.Key, pair.Value);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            c.Stop();
            Console.WriteLine("\nTime is running program {0}", c.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
