using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 105000;
            int count = 1;

            for (long i = 2; i < n; i++)
            { 
                if(isPrime(i))
                {
                    //count++;
                    Console.WriteLine("i = {0}  count = {1}", i, count++);
                }
            }
            Console.ReadLine();                        
        }

        static bool isPrime(long number)
        {
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
