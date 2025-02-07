using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_53
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> myList = new List<BigInteger>();
            try
            {
                for (int n = 2; n <= 100; n++)
                {
                    for (int k = 1; k < n; k++)
                    {
                        BigInteger c = Factorial(n) / (Factorial(k) * Factorial(n - k));
                        if (c > 1000000)
                        {
                            myList.Add(c);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Count = {0}", myList.Count);
            Console.ReadKey();
        }
        private static BigInteger Factorial(BigInteger n)
        {
            if (n > 1)
                return n * Factorial(n - 1);
            else
                return 1;
        }
    }
}
