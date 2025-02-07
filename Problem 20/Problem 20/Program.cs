using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = 100;
            string fact;
            int sum = 0;

            fact = Convert.ToString(F(n));            
            
            for (int i = 0; i < fact.Length; i++)
            {
                sum += int.Parse(fact.Substring(i, 1));
            }
            Console.Write("Sum of the digits in the number 100! = {0}", sum);
            Console.ReadLine();
        }

        static BigInteger F(BigInteger n)
        {
            if (n == 0)
                return 1;
            else
                return n * F(n - 1);
        }
    }
}
