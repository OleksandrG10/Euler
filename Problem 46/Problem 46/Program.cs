using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_46
{
    class Program
    {
        private static List<int> myList = new List<int>();
        private static List<int> oddList = new List<int>();
        static void Main(string[] args)
        {
            try
            {
                int i = 190;
                bool exit = false;
                //for (int i = 4; i < 30; i++)
                while(i != 300)
                {
                    if (!isPrime(i) && (i % 2) != 0)                    
                    {
                        for (int j = 2; j <= i / 2; j++)
                        {
                            if (isPrime(j) && !myList.Contains(i))
                            {
                                myList.Add(i);
                                //break;
                            }
                            //else if (isPrime(j) && !oddList.Contains(i))
                            //{
                            //    oddList.Add(i);
                            //}
                        }                            
                    }
                    i++;
                }

                foreach (var s in myList)
                {
                    Console.Write("{0} ", s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }       
        private static bool isPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}
