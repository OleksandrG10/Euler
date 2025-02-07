using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Numerics;
using System.Diagnostics;

namespace Problem_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;
            int result = 0;
            int x = 0;
            
            Stopwatch c = Stopwatch.StartNew();

            for (int num = 1; num <= 10000; num++)
            {
                for (int factor = 1; factor < num; factor++)
                {
                    x = num % factor;
                    if (x == 0)
                        sum1 = sum1 + factor;
                }
                if (num != sum1)
                {
                    for (int factor = 1; factor < sum1; factor++)
                    {
                        x = sum1 % factor;
                        if (x == 0)
                            sum2 = sum2 + factor;
                    }
                }
                if (num == sum2)
                {
                    result += num;
                    Console.Write("{0}\t", num);
                }
                
                sum1 = 0;
                sum2 = 0;
            }
            c.Stop();
            Console.Write("\nThe sum of all the amicable numbers under 10000. Sum = {0}", result);
            Console.WriteLine("\nThe time run programm {0} ms", c.ElapsedMilliseconds);
            Console.ReadLine();
        }        
    }
}
