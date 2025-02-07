using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = false;
            int a = 0;
            int b = 0;
            int c = 0;
            int s = 1000;
            int product = 1;

            for (a = 1; a < s / 3; a++)
            {
                for (b = a; b < s / 2; b++)
                {
                    c = s - a - b;
                    if (a * a + b * b == c * c)
                    {
                        isPrime = true;
                        break;
                    }
                }
                if (isPrime)
                    break;
            }

            Console.WriteLine("a = {0}\nb = {1}\nc = {2}", a, b, c);
            Console.WriteLine("Product (a*b*c) = {0}", product = a * b * c);
            Console.ReadLine();
        }
    }
}
