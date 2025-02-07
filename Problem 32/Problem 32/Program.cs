using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch c = Stopwatch.StartNew();
            try
            {
                List<int> myList = new List<int>();
                Regex rx = new Regex("(?!.*([1-9]).*\\1)^[1-9]{9}$");
                Match match;
                int multOne = 1;                
                int product;
                string strNumber = string.Empty;                
                int sumPandigital = 0;

                while (multOne < 2000)
                {
                    for(int multTwo = 1; multTwo < 2000; multTwo++)                  
                    {
                        product = multOne * multTwo;
                        strNumber += Convert.ToString(multOne);
                        strNumber += Convert.ToString(multTwo);
                        strNumber += Convert.ToString(product);
                        match = rx.Match(strNumber);
                        if (match.Success)
                        {
                            if (!myList.Contains(product))
                            {
                                myList.Add(product);
                                Console.WriteLine("{0} x {1} = {2}", multOne, multTwo, product);
                            }                            
                        }
                        strNumber = "";                        
                    }
                    multOne++;
                }

                foreach(var n in myList)
                {
                    sumPandigital+= n;
                }
                Console.WriteLine("Sum = {0}", sumPandigital);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            c.Stop();
            Console.WriteLine("\nTime is running program {0}", c.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
