using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_56
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            BigInteger sum = 0;
            BigInteger maxSum = 0;

            try
            {
                for (int a = 1; a < 100; a++)
                {
                    for (int b = 1; b < a; b++)
                    {
                        BigInteger power = BigInteger.Pow(a, b);
                        result = Convert.ToString(power);

                        foreach (char ch in result)
                        {                            
                            sum += BigInteger.Parse(ch.ToString());
                        }

                        if (sum > maxSum)
                            maxSum = sum;

                        sum = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Maximum sum = {0}", maxSum);
            Console.ReadKey();
        }
    }
}
