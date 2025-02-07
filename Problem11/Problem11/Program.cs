using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum of four array elements\n");

            string filePath = "f:\\Проекти\\Project Euler\\Problem11\\Problem11\\bin\\Debug\\numbers.txt";
            const int numbersInProduct = 4;            
            decimal product = 0;
                        
            //читаємо дані з файлу в масив
            int[,] inputSquare = ReadFile(filePath);
                
            for (int i = 0; i < inputSquare.GetLength(0); i++)
            {
                for (int j = 0; j < inputSquare.GetLength(1); j++)
                {
                    decimal tempProd;
                    
                    //Горизинтальний обхід
                    if (i < inputSquare.GetLength(0) - numbersInProduct)
                    {
                        tempProd = inputSquare[i,j];

                        for (int n = 1; n < numbersInProduct; n++)
                        {
                            tempProd = tempProd * inputSquare[i + n, j];                            
                        }                        
                        product = Math.Max(product, tempProd);
                    }                    

                    //Вертикальний обхід
                    if (j < inputSquare.GetLength(0) - numbersInProduct)
                    {
                        tempProd = inputSquare[i, j];

                        for (int n = 1; n < numbersInProduct; n++)
                        {
                            tempProd = tempProd * inputSquare[i, j + n];
                        }                        
                        product = Math.Max(product, tempProd);
                    }                    

                    //Діагональ, з верхнього лівого кутка 
                    if ((i < inputSquare.GetLength(0) - numbersInProduct) && (j >= numbersInProduct))
                    {
                        tempProd = inputSquare[i, j];

                        for (int n = 1; n < numbersInProduct; n++)
                        {
                            tempProd = tempProd * inputSquare[i + n, j - n];
                        }                        
                        product = Math.Max(product, tempProd);
                    }                    

                    //Діагональ, з нижнього лівого кутка
                    if ((j < inputSquare.GetLength(0) - numbersInProduct) && (i < inputSquare.GetLength(1) - numbersInProduct))
                    {
                        tempProd = inputSquare[i, j];

                        for (int n = 1; n < numbersInProduct; n++)
                        {
                            tempProd = tempProd * inputSquare[i + n, j + n];
                        }                     
                        product = Math.Max(product, tempProd);
                    }                    
                }
            }
            Console.WriteLine("Max = {0}", product);
            Console.ReadLine();
        }

        public static int[,] ReadFile(string filePath)
        {
            int lines = 0;
            string line;
            string[] linePieces;

            StreamReader r = new StreamReader(filePath);
            while (r.ReadLine() != null)
            {
                lines++;
            }

            int[,] inputSquare = new int[lines, lines];
            r.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = r.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int i = 0; i < linePieces.Length; i++)
                {
                    inputSquare[j, i] = int.Parse(linePieces[i]);
                }
                j++;
            }
            
            r.Close();

            return inputSquare;             
        }
    }
}
