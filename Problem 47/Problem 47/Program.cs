using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_47
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> factors = new List<int>();
            List<int> factor = new List<int>();
            Dictionary<int, List<int>> myDict = new Dictionary<int, List<int>>();
            Dictionary<int, int> countFactors = new Dictionary<int, int>();
            int count = 0;

            for (int i = 1000; i <= 9999; i++)
            {
                factors = FindFactor(i);                
                foreach (var f in factors)
                {
                    for (int j = 0; j < factors.Count; j++)
                    {
                        if (f == factors[j])
                        {
                            if(!factor.Contains(factors[j]))
                                factor.Add(f);
                            factors.Remove(factors[j]);
                            factors.Insert(j, 0);
                            count++;
                        }
                    }
                }
                if (factors.Count == 4)
                    myDict.Add(i, factors);
            }

            foreach (var pair in myDict)
            {
                Console.Write("{0} = ", pair.Key);
                Console.Write("(");
                
                foreach(var p in pair.Value)
                {
                   
                   
                     Console.Write("{0}^{1}", p.ToString(), count);
                   
                    //Console.Write("{0}", p.ToString());
                    if (pair.Value.Last() != p)
                        Console.Write("x");
                }
                Console.Write(") ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static List<int> FindFactor(int number)
        {
            List<int> result = new List<int>();
            
            while (number % 2 == 0)
            {
                result.Add(2);
                number /= 2;            
            }

            int factor = 3;
            while (factor * factor <= number)
            {
                if (number % factor == 0)
                {
                    result.Add(factor);
                    number /= factor;
                }
                else
                {
                    factor += 2;
                }
            }

            if (number > 1)
                result.Add(number);

            return result;

        }
    }
}
