using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> distinctTerms = new List<BigInteger>();

            for (BigInteger a = 2; a <= 100; a++)
            {
                for (BigInteger b = 2; b <= 100; b++)
                {
                    BigInteger n = Powers(a, b);
                    if (!distinctTerms.Contains(n))
                        distinctTerms.Add(n);
                }
            }

            for (int i = 0; i < distinctTerms.Count; i++)
            {
                Console.Write("{0} ", distinctTerms[i].ToString());
            }

            Console.WriteLine();
            Console.WriteLine("\nCount = {0}", distinctTerms.Count);
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static BigInteger Powers(BigInteger a, BigInteger b)
        {
            BigInteger power = 2;
            for (int i = 2; i <= b; i++)
            {
                power *= a;
            }
            return power;
        }
    }
}
