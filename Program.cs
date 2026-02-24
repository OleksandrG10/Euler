using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> results = new List<long>();
            bool[] used = new bool[10];

            FindPandigitals("", used, results);
            long sum = results.Sum();

            Console.WriteLine("Pandigital numbers found:");
            foreach (var num in results)
                Console.WriteLine(num);
            Console.WriteLine("\nSum = {0}", sum);
            Console.ReadLine();
        }

        static void FindPandigitals(string current, bool[] used, List<long> results)
        { 
            int length = current.Length;
            if (length == 10)
            {
                if (IsValid(current))
                    results.Add(long.Parse(current));
                return;
            }            
            for (int i = 0; i <= 9; i++)
            {
                if (used[i]) continue;

                // Pruning: Check divisibility rules as we build the string
                if (IsValid(current + i))
                {
                    used[i] = true;
                    FindPandigitals(current + i, used, results);
                    used[i] = false; // Backtrack
                }
            }
        }
        static bool IsValid(string s)
        {
            int n = s.Length;

            if(n >= 4 && int.Parse(s.Substring(1, 3)) % 2 != 0)
                return false;
            if (n >= 5 && int.Parse(s.Substring(2, 3)) % 3 != 0)
                return false;
            if (n >= 6 && int.Parse(s.Substring(3, 3)) % 5 != 0)
                return false;
            if (n >= 7 && int.Parse(s.Substring(4, 3)) % 7 != 0)
                return false;
            if (n >= 8 && int.Parse(s.Substring(5, 3)) % 11 != 0)
                return false;
            if (n >= 9 && int.Parse(s.Substring(6, 3)) % 13 != 0)
                    return false;
            if (n >= 10 && int.Parse(s.Substring(7, 3)) % 17 != 0)
                return false;

            return true;
        }
    }
}
