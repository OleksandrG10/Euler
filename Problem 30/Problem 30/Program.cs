using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_30
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            int number;
            int sumPower = 0;
            string str = "";

            for (int i = 1; i < 1000000; i++)
            {
                str = Convert.ToString(i);
                number = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    number += Power(int.Parse(str[j].ToString()), 5);
                }

                if ((i == number) && (i != 1))
                {
                    sumPower += number;
                    myList.Add(number);
                }
            }
            
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i].ToString() + " ");
            }

            Console.WriteLine();
            Console.WriteLine("\nSum power = {0}", sumPower);
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        private static int Power(int j, int p)
        {
            int power = 1;
            for (int i = 0; i < p; i++)
            {
                power *= j;
            }

            return power;
        }
    }
}
