using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_41
{
    class Program
    {
        /// <summary>
        /// The largest n-digit pandigital prime = 7652413
        /// between 1000000 - 1000000
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Stopwatch c = Stopwatch.StartNew();

            string strNumber = string.Empty;
            Regex regex = new Regex("(?!.*([1-9]).*\\1)^[1-9]{1,9}$");            
            Match match;
            long maxPanDigit = 1;

            for (long i = 1000000; i < 10000000; i++)
            {
                strNumber = Convert.ToString(i);
                match = regex.Match(strNumber);
                if (match.Success)
                {
                    long panDigit = long.Parse(strNumber);
                    if (isPrime(panDigit))
                    {                        
                        if (panDigit > maxPanDigit)
                            maxPanDigit = panDigit;
                    }
                }
            }
            
            Console.Write("\nThe largest n-digit pandigital prime = {0}", maxPanDigit);
            c.Stop();
            Console.Write("\nTime si running program {0}", c.ElapsedMilliseconds);
            Console.ReadKey();
        }

        private static bool isPrime(long number)
        {
            for (long i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                    return false;
            return true;
        }

    }
}
