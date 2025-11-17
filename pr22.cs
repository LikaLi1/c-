using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int row = 3;
            const int cols = 4;
            Random rnd = new Random(); 
            int[,] a = new int[row, cols];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(10, 99);
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} "); 
                }
                Console.WriteLine();
            }

            int[] minValues = new int[row];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int minValue = a[i, 0];
                for (int j = 1; j < a.GetLength(1); j++)
                {
                    if (minValue > a[i, j])
                    {
                        minValue = a[i, j];
                    }
                }
                minValues[i] = minValue;
            }

            for (int i = 0; i < minValues.Length; i++)
            {
                Console.Write($"{minValues[i]} ");
            }
            Console.WriteLine();
        }
    }
}
