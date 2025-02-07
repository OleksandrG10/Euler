using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int num = 2000000;
            long sum = 0;
            for (int i = 2; i < num; i++)
            {
                if (isPrime(i))
                    sum += i;
            }
            Console.Write("sum = {0}", sum);
            Console.ReadLine();
        }
        
        static bool isPrime(int n)
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
