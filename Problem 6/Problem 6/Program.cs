using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum of the numbers in power
            double sumPowerTwo = 0;

            //power of the sum
            double powerTwoSum = 0;
            double n = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumPowerTwo += Math.Pow(i, 2);
                n += i;
            }
            powerTwoSum = Math.Pow(n, 2);

            double diffBetweenSum = powerTwoSum - sumPowerTwo;
            Console.WriteLine("Difference between the sum = {0}", diffBetweenSum);
            Console.Write("\nPress any key...");
            Console.ReadKey();
        }
    }
}
