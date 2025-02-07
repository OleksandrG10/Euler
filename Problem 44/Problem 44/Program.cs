using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch clock = Stopwatch.StartNew();

            int result = 0;
            bool notFound = true;
            int i = 1;
            int j = 0;

            while (notFound)
            {
                i++;
                int n = i * (3 * i - 1) / 2;
                for (j = i - 1; j > 0; j--)
                {
                    int m = j * (3 * j - 1) / 2;
                    if (isPentagon(n - m) && isPentagon(n + m))
                    {
                        result = n - m;
                        notFound = false;
                        break;
                    }
                }
            }


            // My code. Don't work

            //List<int> pentagon = new List<int>();
            //List<int> D = new List<int>();

            //int limit = 7000;

            //for (int n = 5000; n <= limit; n++)
            //{
            //    pentagon.Add(n * (3 * n - 1) / 2);
            //}

            //int sum = 0;
            //int difference = 0;

            //for (int i = 0; i < pentagon.Count; i++)
            //{
            //    for (int j = 0; j < pentagon.Count; j++)
            //    {
            //        sum = pentagon[i] + pentagon[j];
            //        difference = pentagon[j] - pentagon[i];

            //        if (pentagon.Contains(sum) && pentagon.Contains(difference))
            //        {
            //            D.Add(difference);
            //        }
            //        sum = 0;
            //        difference = 0;
            //    }
            //}

            //foreach (var min in D)
            //{

            //}

            clock.Stop();
            Console.WriteLine("k = {0}, j = {1}", i, j);
            Console.WriteLine("The value of D is {0}", result);
            Console.WriteLine("Time is running program {0}", clock.ElapsedMilliseconds);
            Console.ReadKey();
        }

        private static bool isPentagon(int number)
        {
            double penTest = (Math.Sqrt(24 * number + 1) + 1.0) / 6.0;
            return penTest == ((int)penTest);
        }
    }
}
