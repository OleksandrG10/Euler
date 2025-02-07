using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_60
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            int limit = 100000;
            List<int> prime = new List<int>();

            try
            {
                while (number < limit)
                {
                    if(isPrime(number))

                }
            }
            catch (Exception ex)
            {

            }
            Console.ReadLine();
        }

        static bool isPrime(long number)
        {
            for (long i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                    return false;
            return true;
        }

    }
}
