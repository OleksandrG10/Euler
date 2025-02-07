using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem_24
{
    class Program
    {
        static int[] perm = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        static void Main(string[] args)
        {
            BruteForce();
            Factor();
            Console.ReadLine();
        }

        private static void BruteForce()
        {
            Stopwatch clock = Stopwatch.StartNew();

            int count = 1;
            int numPerm = 1000000;

            while (count < numPerm)
            {
                int N = perm.Length;
                int i = N - 1;

                while (perm[i - 1] >= perm[i])
                {
                    i = i - 1;
                }

                int j = N;
                while (perm[j - 1] <= perm[i - 1])
                {
                    j = j - 1;
                }

                Swap(i - 1, j - 1);

                i++;
                j = N;

                while (i < j)
                {
                    Swap(i - 1, j - 1);
                    i++;
                    j--;
                }
                count++;
            }

            string permNum = "";
            for (int k = 0; k < perm.Length; k++)
            {
                permNum = permNum + perm[k];
            }
            
            clock.Stop();
            Console.WriteLine("The millionth lexicographic permutation {0}", permNum);
            Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
        }

        private static void Swap(int i, int j)
        {
            int temp = perm[i];
            perm[i] = perm[j];
            perm[j] = temp;
        }

        private static void Factor()
        {
            Stopwatch clock = Stopwatch.StartNew();

            int N = perm.Length;
            string permNum = "";
            int remain = 1000000 - 1;

            List<int> numbers = new List<int>();
            for (int i = 0; i < N; i++)
                numbers.Add(i);

            for (int i = 1; i < N; i++)
            {
                int j = remain / Factorial(N - i);
                remain = remain % Factorial(N - i);

                permNum = permNum + numbers[j];
                numbers.RemoveAt(j);

                if (remain == 0)
                    break;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                permNum = permNum + numbers[i];
            }

            clock.Stop();
            Console.WriteLine("The millionth lexicographic permutation {0}", permNum);
            Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
        }

        private static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}
