using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Numerics;

namespace Problem_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch c = Stopwatch.StartNew();
            int count = 0;
            int countFib = 0;
            Console.WriteLine("Fibonacci sequence");            

            foreach (BigInteger f in Fibonacci())
            {                
                string str = Convert.ToString(f);
                foreach (var s in str)                
                {
                    count++;
                    if (count == 1000)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Count = {0},", countFib);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("  Fibonacci = {0}", f);
                        goto found;
                    }
                }
                count = 0;
                countFib++;             
            }
            c.Stop();
        found:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nThe time run programm {0} ms", c.ElapsedMilliseconds);
            Console.ReadLine();

        }

        private static IEnumerable<BigInteger> Fibonacci()
        {
            yield return 1;
            BigInteger i = 0, j = 1;
            while (true)
            {
                yield return j;
                BigInteger temp = i;
                i = j;
                j = temp + j;
            }
        }
    }
}
