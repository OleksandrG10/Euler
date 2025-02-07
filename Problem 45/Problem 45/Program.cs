using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Numerics;

namespace Problem_45
{
    class Program
    {
        //T - Triangle Tn=n(n+1)/2
        //P - Pentagonal Pn=n(3n−1)/2	
        //H - Hexagonal	 Hn=n(2n−1)

        static void Main(string[] args)
        {
            Stopwatch time = Stopwatch.StartNew();           
            int limit = 40000;
            decimal Pn = 0;
            decimal Hn = 0;
           
            for (decimal i = 165; i < limit; i++)
            {                
                for (decimal j = 143; j < limit; j++)
                {
                    Pn = i * (3 * i - 1) / 2;
                    Hn = j * (2 * j - 1);
                    if (Pn == Hn)
                    {                        
                        Hn = j * (2 * j - 1);
                        Console.WriteLine("P[{0}] = H[{1}] = {2}", i, j, Hn);
                    }
                }
            }

            time.Stop();
            Console.WriteLine();
            Console.WriteLine("Time run program {0:f7} minutes", (time.ElapsedMilliseconds * 0.0001) / 60);
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
