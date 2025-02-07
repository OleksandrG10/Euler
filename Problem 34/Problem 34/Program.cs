using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_34
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 1000000;
            string str = "";
            int sumFact;
            int sumNumbers = 0;
            List<int> list = new List<int>();
            
            for (int i = 3; i < n; i++)
            {
                sumFact = 0;
                str = Convert.ToString(i);
                for (int j = 0; j < str.Length; j++)
                {
                    sumFact += Factorial(int.Parse(str[j].ToString()));
                }
                if (sumFact == i)
                {
                    sumNumbers += i;
                    list.Add(i);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i].ToString() + " ");
            }

            Console.WriteLine();
            Console.Write("\nSum = {0}", sumNumbers);
            Console.WriteLine();
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        private static int Factorial(int p)
        {
            if ((p == 0) || (p == 1))
                return 1;
            return p * Factorial(p - 1);
        }
    }
}
