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
         int[,] a = { {1,2,3}, {4,5,6}, {7,8,9} };
         for(int i = 0; i < 3; i++)
         {
            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine(a[i,j]);
            }
         }
         Console.WriteLine(a[0,1]);   
        }
    }
}
