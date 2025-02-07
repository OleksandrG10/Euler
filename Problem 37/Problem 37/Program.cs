using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem_37
{
    class Program
    {        
        static void Main(string[] args)
        {
            Stopwatch c = Stopwatch.StartNew();
            int n = 10;            
            List<int> tPrime = new List<int>();
            try
            {
                while (tPrime.Count < 11)
                {
                    if (isLeftTruncatablePrime(n) && isRightTruncatablePrime(n))
                    {
                        string str = Convert.ToString(n);
                        if (str.Length > 1 && !str.Contains("1"))
                        {
                            int m = Convert.ToInt32(str);
                            if(!tPrime.Contains(m))
                                tPrime.Add(n);                            
                        }
                        else if (str.Length > 2 && str.LastIndexOf('1') == 1 && str.First().ToString() != "1")
                        {
                            int k = Convert.ToInt32(str);
                            if (!tPrime.Contains(k))
                                tPrime.Add(k);                            
                        }                       
                    }
                    n++;
                }

                int sum = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (int i in tPrime)
                {
                    
                    Console.Write("{0} ", i);
                    sum += i;
                }
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("\nThe sum of the only eleven primes that are both truncatable from left to right" +
                    " and right to left: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0}", sum);
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            c.Stop();
            
            Console.WriteLine();
            Console.Write("\nCount prime elements: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}", tPrime.Count);
            Console.ResetColor();
            Console.WriteLine();            
            Console.Write("Run time programming ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} ms", c.ElapsedMilliseconds);
            Console.ResetColor();
            Console.ReadKey();
        }

        private static bool isRightTruncatablePrime(int n)
        {
            for (;;)
            {
                n /= 10;
                if (n == 0)
                    return true;
                if (!isPrime(n))
                    return false;
            }
        }

        private static bool isLeftTruncatablePrime(int n)
        {
            string str = Convert.ToString(n);

            if (str.Contains("0"))
                return false;
            for (int i = 0; i < str.Length; i++)
                if (!isPrime(Convert.ToInt32(str.Substring(i))))
                    return false;

            return true;
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
