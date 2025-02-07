using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_49
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prime = new List<int>();
            try
            {
                for (int i = 1000; i < 10000; i++)
                {
                    if (isPrime(i))
                        prime.Add(i);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
