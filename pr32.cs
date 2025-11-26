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

        static double powerA(double A, int B)
        {
            double temp = A;
            for (int i = 0; i < B - 1; i++)
            {
                temp *= A;
            }
            return A;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(powerA(3, 3));
        }
    }
}
