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
            Console.WriteLine("В ряд");
            for (int i = 1; i < 7; i++) 
            {
                Console.Write(i);
                for (int j = 1; j < 7; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Триугольник");

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
