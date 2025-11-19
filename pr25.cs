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
            Console.Write("Введите значение m: ");
            Int32.TryParse(Console.ReadLine(), out int m);

            Console.Write("Введите значение n: ");
            Int32.TryParse(Console.ReadLine(), out int n);

            int[,] arr = new int[m, n];
            Random rnd = new Random();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(1, 10); 
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Введите значение k1: ");
            Int32.TryParse(Console.ReadLine(), out int k1);

            Console.Write("Введите значение k2: ");
            Int32.TryParse(Console.ReadLine(), out int k2);
            
            for (int j = 0; j < n; j++) 
            {
                int c = arr[k1, j]; 
                arr[k1, j] = arr[k2, j]; 
                arr[k2, j] = c;   
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
