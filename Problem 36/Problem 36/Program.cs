using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problem_36
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limit = 1000000;
            BigInteger sumPol = 0;

            for (int i = 1; i < limit; i++)
            {
                if (isPolindrom(i))
                {
                    string stemp = DecimalToBinary(i);
                    if (isPolindrom(BigInteger.Parse(stemp)))
                    {
                        sumPol += i;
                        Console.Write(i.ToString() + " ");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("\nSum = {0}", sumPol);
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        private static string DecimalToBinary(int number)
        {
            int remainder = 0;
            string result = string.Empty;
            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                result = remainder.ToString() + result;
            }

            return result;
        }

        private static bool isPolindrom(BigInteger number)
        {
            BigInteger next = 0;
            BigInteger pol = number;

            while (pol != 0)
            {
                next = (next * 10) + (pol % 10);
                pol /= 10;
            }

            if (number == next)
                return true;
            else
                return false;
        }
    }
}
