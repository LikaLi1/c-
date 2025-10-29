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
                Console.WriteLine("*");
            }
            Console.WriteLine("В строку");
            for (int i = 1; i < 7; i++)
            {
                Console.Write("*");
            }
        }
    }
}
