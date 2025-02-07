using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxValue = 1000000;
            int position = 0;
            long n;
            
            //лічильник
            int count = 1;

            //максимальний
            int maxCount = 0;

            Stopwatch stopWatch = Stopwatch.StartNew();

            for (int i = 2; i <= maxValue; i++)
            {
                count = 0;                              
                
                for (n = i; n != 1;)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                        count++;
                    }
                    else
                    {
                        n = 3 * n + 1;
                        count++;
                    }                   
                }         
                
                if (count > maxCount)
                {
                    maxCount = count;
                    position = i;
                }
            }            
            Console.WriteLine("\nMax count element {0}, position {1}", maxCount, position);

            stopWatch.Stop();
            Console.Write("\nThe programm run {0} ms", stopWatch.ElapsedMilliseconds);
            Console.ReadLine();
        }        
    }
}
