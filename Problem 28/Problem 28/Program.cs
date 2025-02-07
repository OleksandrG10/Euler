using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problem_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = Stopwatch.StartNew();
            int n = 1001;
            int[,] array = new int[n, n]; ;
            int sum = 0;
            int i = 0;
            int j = 0;
            int sumLeft = 0;
            int sumRight = 0;
                                    
            SpiralMatrix(array, n);

            while (i < n)
            {
                sumLeft += array[i, j];
                i++;
                j++;
            }

            i = n - 1;
            j = 0;
            while (i >= 0)
            {
                sumRight += array[i, j];
                i--;
                j++;
            }

            sum = sumLeft + sumRight;
            if ((n % 2) == 1)
                sum -= 1;
                                   
            Console.WriteLine("\nSum = {0}", sum);            
            Console.WriteLine("\nTime run program {0}", time.ElapsedMilliseconds);
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();

        }

        private static void SpiralMatrix(int[,] array, int n)
        {
            //The middle of matrix
            int positionX = (n % 2) == 0 ? (n / 2) - 1 : n / 2;//n / 2;
            int positionY = (n % 2) == 0 ? (n / 2) - 1 : n / 2;

            int direction = 0;
            int stepsCount = 1;
            int stepPosition = 0;
            int stepChange = 0;

            for (int i = 1; i <= n * n; i++)
            {
                // Fill the current cell with the current value
                array[positionY, positionX] = i;

                // Check for direction / step changes
                if (stepPosition < stepsCount)
                {
                    stepPosition++;
                }
                else
                {
                    stepPosition = 1;
                    if (stepChange == 1)
                    {
                        stepsCount++;
                    }
                    stepChange = (stepChange + 1) % 2;
                    direction = (direction + 1) % 4;
                }

                // Move to the next cell in the current direction
                switch (direction)
                {
                    // N = 3
                    // 7  8  9
                    // 6  1  2
                    // 5  4  3

                    case 0:
                        positionX++;
                        break;

                    case 1:
                        positionY++;
                        break;

                    case 2:
                        positionX--;
                        break;

                    case 3:
                        positionY--;
                        break;

                    
                    // N = 3
                    // 5  6  7
                    // 4  1  8
                    // 3  2  9

                    //case 0:
                    //    positionY++;
                    //    break;
                    //case 1:
                    //    positionX--;
                    //    break;
                    //case 2:
                    //    positionY--;
                    //    break;
                    //case 3:
                    //    positionX++;
                    //    break;

                }
            }
        } 
    }
}
