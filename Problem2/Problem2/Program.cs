using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    class Program
    {
        public static IEnumerable<long> fib()
        {
            yield return 0;
            long i = 0, j = 1;
            while (true)
            {
                yield return j;
                long temp = i;
                i = j;
                j = temp + j;
            }

        }
        static void Main(string[] args)
        {
            long sum = 0;            

            foreach (long n in fib())
            {                
                if (n > 4000000)
                    break;
                if(n%2 == 0)
                    sum += n;
                Console.Write("{0}\t", n);
            }
            Console.Write("\nSum = {0}", sum);
            Console.ReadLine();
        }
    }
}