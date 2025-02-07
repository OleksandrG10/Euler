using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 300001;
            int multiply = 1;
            int count = 0;
            int j = 1;
            string c = string.Empty;

            try
            {
                for (int i = 1; i <= n; i++)
                {
                    decimal k;
                    double m = Math.Pow(10, i);
                    k = Convert.ToDecimal(i % m); 
                    c += Convert.ToString(k);
                }
                
                while(j < c.Length)
                {
                    if (n != c.Length)
                    {
                        string str = c[j - 1].ToString();
                        multiply *= int.Parse(str);
                        Console.WriteLine("Digital at {0}: {1}", j, str);
                    }
                    count++;
                    j = j * 10;
                }
                Console.WriteLine("Multiply d[1] x d[10] x d[100] x d[1000] x d[1000] x d[100000] x d[1000000] = {0}", multiply);
                Console.WriteLine("count = {0}", count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }               
    }
}
