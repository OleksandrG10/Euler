using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_33
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int denproduct = 1;
                int nomproduct = 1;
                for (int i = 1; i < 10; i++)
                {
                    for (int den = 1; den < i; den++)
                    {
                        for (int nom = 1; nom < den; nom++)
                        {
                            if ((nom * 10 + i) * den == nom * (10 * i + den))
                            {
                                denproduct *= den;
                                nomproduct *= nom;
                                Console.WriteLine("({0}, {1})", nomproduct, denproduct);
                            }
                        }
                    }
                }
                denproduct /= NSD(nomproduct, denproduct);
                Console.WriteLine("The product of denomirators {0}", denproduct);
                //for (int i = 99; i > 10; i--)
                //{
                //    for (int j = 99; j > 10; j--)
                //    {
                //        int f = j / i;
                //        if (f < 1)
                //        {
                //            if (NSD(j,i) != 1)
                //            {
                //                int a = NSD(j, i);                                
                //                Console.Write("{0}/{1}, NSD({2},{3}) = {4} ", j, i, j, i, a);
                //                Console.WriteLine();
                //                count++;
                //                //nsd.Add(a);
                //                //if (!fraction.ContainsKey(j))
                //                //    fraction.Add(j, i);
                //            }
                //            //for (int k = 0; k < dividers.Length; k++)
                //            //{
                //            //    if ((i % dividers[k] == 0) && (j % dividers[k] == 0))
                //            //    {
                //            //        if(!fraction.ContainsKey(j))
                //            //        fraction.Add(j, i);
                //            //    }
                //            //}
                //        }
                //    }
                //}

                
                Console.ReadLine();
            }
            catch (DivideByZeroException zero)
            {
                Console.WriteLine(zero.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            
        }

        private static int NSD(int a, int b)
        {
            int x = 0;
            int y = 0;

            if (a > b)
            {
                x = a;
                y = b;
            }
            else
            {
                x = b;
                y = a;
            }

            while (x % y != 0)
            {
                int temp = x;
                x = y;
                y = temp % x;
            }

            return y;
        }
    }
}
