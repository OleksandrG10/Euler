using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    if (isPolindrom(i * j))
                    {
                        myList.Add(i * j);
                        Console.Write("{0}\t", i * j);
                    }
                }                
            }

            int max = 0;
            foreach (int n in myList)
            {
                if (n > max)
                    max = n;
            }
            Console.WriteLine("\nmax = {0}", max);
            Console.ReadLine();
        }                
 
        static bool isPolindrom(int number)
        {
            int next = 0;
            int pol2 = number;

            while (pol2!=0)
            {
                next = (next * 10) + (pol2 % 10);
                pol2 /= 10;
            }

            if (number == next)
                return true;
            else
                return false;
        }       
    }
}
