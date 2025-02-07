using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 спосіб
            int sum = 0;
            BigInteger n = BigInteger.Pow(2, 1000);
            while (n > 0)
            {
                sum += (int)(n % 10);
                n /= 10;
            }
            
            //2 спосіб
            //BigInteger n = BigInteger.Pow(2, 1000).ToString().Aggregate(0, (total, next) => total + (int)Char.GetNumericValue(next));
            
            Console.Write("sum = {0}", sum);
            Console.ReadLine();
        }

       
    }
}
