using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Numerics;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            const long primeNumber = 600851475143;
            var primeFactors = Enumerable.Range(2, Convert.ToInt32(Math.Sqrt(primeNumber)))
                                          .Reverse()
                                          .AsParallel()
                                          .Where(g => primeNumber % g == 0 && isPrime(g))
                                          .FirstOrDefault();
            
                        
            
            Console.WriteLine("Max = {0}", primeFactors);
            Console.ReadLine();
        }

        //перевіряємо чи просте число 
        static bool isPrime(long number)
        {
            for (long i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
} 
