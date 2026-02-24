using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfRoot = 0;

            for (BigInteger i = 2; i < 100; i++)
            {
                if (Math.Sqrt((double)i) % 1 != 0)
                {
                    // To get the first 100 decimal digits of the square root, we can multiply the number by 10^(2*precision) and then take the integer part of the square root.
                    int precision = 99;
                    BigInteger target = i * BigInteger.Pow(10, precision * 2);
                    BigInteger x = BigInteger.Pow(10, precision); // Initial guess
                    BigInteger lastX = 0; 

                    while (BigInteger.Abs(x - lastX) > 0)
                    { 
                        lastX = x;
                        x = (x + target / x) / 2; // Newton's method
                    }
                    string fullSqrt = x.ToString();                                        
                    sumOfRoot += SumDigits(fullSqrt);
                }
            }
            Console.WriteLine("The total of the digital sums  = {0}", sumOfRoot); 
        }
        private static int SumDigits(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }
            return sum;
        }
    }
}
