using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 => 'Sunday',
            //1 => 'Monday',
            //2 => 'Tuesday',
            //3 => 'Wednesday',
            //4 => 'Thursday',
            //5 => 'Friday',
            //6 => 'Saturday'
            
            int y = 0;
            int count = 0;
            for (int years = 1901; years <= 2000; years++)
            {
                Console.Write("Years {0}:", years);
                for (int month = 1; month <= 12; month++)
                {
                    y = GetWeekDay(years, month, 1);                    
                    if (y == 0)
                    {
                        Console.Write(" month {0}", month);
                        count++;
                    }
                }
                Console.WriteLine();
            }                
            Console.Write("Count Sunday {0}", count);
            Console.ReadLine();
        }
      
        private static int GetWeekDay(int year, int month, int day)
        {
            //щомісяця компенсувати
            int[] m = new int[] { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

            //після лютого
            int af = month > 2 ? 0 : 1;

            //кожен четвертий рік є високосним, якщо він ділиться на 100, якщо він ділиться на 400
            int w = 5 + (year - 1000) * 365 + (year - 1000 - af) / 4 - (year - 1000 - af) / 100 + (year - 1600 - af) / 400 + m[month - 1] + (day - 1);
            
            return w % 7;
        }

        private static void GetDay(int year, int month, int day)
        {
            string str = Convert.ToString(year);
            string subYear = str.Substring(2, 2);

            Console.WriteLine(subYear);
        }
    }
}
