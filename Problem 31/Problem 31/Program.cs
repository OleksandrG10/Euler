using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 200;
            
            //            
            //The first version of the solution
            //

            //int ways = 0;
            //for (int a = target; a >= 0; a -= 200)
            //{
            //    for (int b = a; b >= 0; b -= 100)
            //    {
            //        for (int c = b; c >= 0; c -= 50)
            //        {
            //            for (int d = c; d >= 0; d -= 20)
            //            {
            //                for (int e = d; e >= 0; e -= 10)
            //                {
            //                    for (int f = e; f >= 0; f -= 5)
            //                    {
            //                        for (int g = f; g >= 0; g -= 2)
            //                        {
            //                            ways++;
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            //
            //The second version of the solution
            //

            int[] coinSizes = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int[] ways = new int[target + 1];
            ways[0] = 1;            

            for (int i = 0; i < coinSizes.Length; i++)
            {
                for (int j = coinSizes[i]; j <= target; j++)
                {
                    ways[j] += ways[j - coinSizes[i]];
                }
            }


            string pound = "£";
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(pound + "2 can be generated in {0} number of ways", ways[200]);
            Console.ReadKey();
        }
    }
}
