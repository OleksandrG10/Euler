using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_26
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 1000;
            double d; 
            double s;
            int count;
            int max = 0;

            for (int i = 2; i <= n; i++)
            {
                d = 1.0 / i;
                int k = (int)d;
                s = d - k;
                string str = Convert.ToString(s);                
                char[] fraction = str.ToCharArray();
                List<int> list = new List<int>();
                List<int> listFraction = new List<int>();
                
                for (int c = 2; c < fraction.Length; c++)
                {
                    list.Add(Convert.ToInt32(Char.GetNumericValue(fraction[c])));
                    //count++;
                }

                count = 0;
                Console.Write("\n1/{0} = 0,", i);
                for (int j = 0; j < list.Count; j++)
                {
                    if (list.Count == 1)
                    {
                        foreach(var el in list )
                        {
                            Console.Write("{0}", el);
                        }
                    }
                    else
                    {
                         if (!listFraction.Contains(list[j]))
                         {                             
                             listFraction.Add(list[j]);                             
                         }
                         count++;
                    }
                }

                if (count > max)
                    max = count;

                //Console.Write("(");
                foreach (var l in listFraction)
                {
                    Console.Write("{0}", l);
                }
                //Console.Write(")");
            }

            Console.WriteLine();
            Console.Write("\nMax count {0}", max);
            Console.WriteLine();
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
