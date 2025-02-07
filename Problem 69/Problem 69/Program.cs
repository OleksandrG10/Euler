using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_69
{
    class Program
    {
        public static float phi(int n)
        {
            float result = n;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                        n /= i;
                    result *= (float)(1.0 - (1.0 / (float)i));
                }
            }
            if (n > 1)
                result *= (float)(1.0 - (1.0 / (float)n));

            return result;
        }
        static void Main(string[] args)
        {
            int n = 2;
            int limit = 1000000;
            float max = 0;
            int p = 0;
            float m;

            try
            {
                while (n <= limit)
                {
                    m = n / phi(n);
                    if (m > max)
                    {
                        max = m;
                        p = n;                        
                    }                    
                    n++;
                }
                Console.WriteLine("n = " + p + "; " + "phi(" + p + ") = " + phi(p) + "; " + "Max (n / phi(n)) = {0}", max);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        
    }
}
