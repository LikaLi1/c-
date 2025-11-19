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
        
            int[,] arr = new int[3, 3];
            Random rnd = new Random();

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    arr[i, j] = rnd.Next(1, 11); 
                }
            }
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr[i, j]} "); 
                }
                Console.WriteLine(); 
            }

            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    sum += arr[i, j];
                }
            }

            Console.WriteLine($"Sum of all elements: {sum}");
        }
    }
}
