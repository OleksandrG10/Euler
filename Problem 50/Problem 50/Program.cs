using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;

namespace Problem_50
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> primes = new List<long>();
            List<long> primeSum = new List<long>();

            long result = 0;
            int numberOfPrimes = 0;
            long n = 1000000;
            int maxSum = 0;

            try
            {
                for (int i = 2; i <= n; i++)
                {
                    if (isPrime(i))
                        primes.Add(i);
                }

                primeSum.Add(0);
                for (int i = 0; i < primes.Count; i++)
                {
                    int m = (int)primes[i];
                    int k = (int)primeSum[i];

                    primeSum.Add(m + k);
                }
                for (int i = numberOfPrimes; i < primeSum.Count; i++)
                {
                    for (int j = i - (numberOfPrimes + 1); j >= 0; j--)
                    {
                        if (primeSum[i] - primeSum[j] > n)
                            break;

                        if (primes.BinarySearch(primeSum[i] - primeSum[j]) >= 0)
                        {
                            numberOfPrimes = i - j;
                            result = primeSum[i] - primeSum[j];
                            if (result > maxSum)
                                maxSum = (int)result;
                           
                        }
                    }
                }
                Console.WriteLine("The prime, below one-million, can be written as the sum of the most consecutive primes {0}", maxSum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static bool isPrime(long n)
        {
            for (long i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}