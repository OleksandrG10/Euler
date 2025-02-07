using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Diagnostics;

namespace Problem_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = Stopwatch.StartNew();

            StringBuilder sb = new StringBuilder();
            BigInteger number = 0;

            for (BigInteger i = 1; i <= 1000; i++)
            {
                number += SelfPowers(i, i);
            }
            
            sb.Append(number);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Self powers = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(sb.ToString());                       
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nLast ten sequence numbers = " + sb.ToString(sb.Length - 10, 10));
            Console.WriteLine();
            time.Stop();            
            Console.WriteLine("\nThe time run programm {0} ms", time.ElapsedMilliseconds);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress any keys...");
            Console.ReadKey();
        }

        private static BigInteger SelfPowers(BigInteger n, BigInteger i)
        {
            BigInteger power = 1;
            for (int j = 1; j <= i; j++)
            {
                power *= n;
            }
            return power;
        }
    }
}
