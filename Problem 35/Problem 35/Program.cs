using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            int limit = 1000000;
            List<int> circularPrime = new List<int>();
            try
            {
                while (number < limit)
                {
                    if (isCircularPrime(number))
                        circularPrime.Add(number);
                    number++;
                }
                foreach (int n in circularPrime)
                {
                    Console.Write("{0} ", n);
                }
                Console.WriteLine("\nThe circular primes below {0}: {1}", limit, circularPrime.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
        private static bool isCircularPrime(int n)
        {
            int count = 0;
            int t = n;
            if (isPrime(n))
            {
                while (t > 0)
                {
                    count++;
                    t /= 10;
                }           
                int number = n;

                while (isPrime(number))
                {
                    int remainder = number % 10;
                    int division = number / 10;
                    number = (int)((Math.Pow(10, count - 1)) * remainder) + division;
                    if (number == n)
                        return true;
                }
            }
            return false;
        }
        private static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
