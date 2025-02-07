using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem12
{
    class Program
    {     
        static void Main(string[] args)
        {                  
            DateTime startDate = DateTime.Now;
            int number = 0;
            int i = 1;
            while (Division(number) < 500)            
            {
                number += i;
                i++;
            }
            Console.WriteLine("Number which has 500 divisors {0}", number);
            
            DateTime endDate = DateTime.Now;
            TimeSpan totalTime = endDate - startDate;
            Console.WriteLine("Time run program {0}", totalTime);
            Console.ReadLine();
        }

        static int Division(int number)
        {
            int nod = 0;            
            int sqrt = (int)Math.Sqrt(number);
            for (int i = 2; i < sqrt; i++)
            {
                if (number % i == 0)
                    nod += 2;
            }

            if (sqrt * sqrt == number)
                nod--;
            return nod;
        }
    }
}
