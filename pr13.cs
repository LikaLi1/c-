using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В ряд с х");
            for (int i = 1; i < 7; i++) 
            {
                Console.WriteLine();
                for (int j = 1; j < 7; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" x ");
                    } else
                    {
                        Console.Write(" * ");
                    }
                } 
                Console.WriteLine();
            }
            Console.WriteLine("В ряд с пробелом");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 7; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
     }
}
