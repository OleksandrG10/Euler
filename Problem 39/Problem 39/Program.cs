using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_39
{
    class Program 
    {
        static void Main(string[] args)
        {            
            int sum = 0;            
            MultiDictionary<int, List<int>> paramaters = new MultiDictionary<int, List<int>>();

            try
            {
                for (int a = 1; a <= 1000; a++)
                {
                    for (int b = a; b <= 1000; b++)
                    {
                        for (int c = a; c <= 1000; c++)
                        {
                            if (a * a + b * b == c * c)
                            {
                                sum = a + b + c;
                                if (sum < 1000)
                                {
                                    paramaters.Add(sum, new List<int> { a, b, c });
                                }
                            }
                        }
                    }
                }

                int maxCount = 1;                

                foreach (var pair in paramaters)
                {                    
                    if (pair.Value.Count > maxCount)
                    {
                        maxCount = pair.Value.Count;
                        sum = pair.Key;                 
                    }                    
                }
                
                var value = paramaters.Where(v => v.Key == sum).SelectMany(v => v.Value).ToList();
                Console.WriteLine("Sum = {0}; ", sum);
                foreach (var v in value)
                {
                    Console.Write("\n(");
                    for (int i = 0; i < v.Count; i++)
                    {                        
                        Console.Write("{0} ", v[i]);
                    }
                    Console.Write("); ");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }        
    }
}
