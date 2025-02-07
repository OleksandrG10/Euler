using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = 20;
            BigInteger s = 0;

            s = Factorial(2 * n) / (Factorial(n) * Factorial(n));

            Console.WriteLine("s = {0}", s);
            Console.ReadLine();
        }

        static BigInteger Factorial(BigInteger n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}
