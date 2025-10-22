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
            Console.Write("Введите длину ребра куба1: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.Write("Введите длину ребра куба2: ");
            Int32.TryParse(Console.ReadLine(), out int b);
            Console.Write("Введите длину ребра куба3: ");
            Int32.TryParse(Console.ReadLine(), out int c);
            double V = a * b * c;
            Console.WriteLine(V);
            Console.Write("Введите длину ребра куба1: ");
            Int32.TryParse(Console.ReadLine(), out int ai);
            Console.Write("Введите длину ребра куба2: ");
            Int32.TryParse(Console.ReadLine(), out int bi);
            Console.Write("Введите длину ребра куба3: ");
            Int32.TryParse(Console.ReadLine(), out int ci);
            double S = 2 * (ai * bi + bi * ci + ai * ci);
            Console.WriteLine(S);
        }
    }
}
