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
            Console.Write("Введите длину ребра куба: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            double V = Math.Pow(a, 3);
            Console.WriteLine(V);
            Console.Write("Введите длину ребра куба: ");
            Int32.TryParse(Console.ReadLine(), out int b);
            double S = 6 * Math.Pow(b, 2);
            Console.WriteLine(S);
        }
    }
}
