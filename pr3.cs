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
            Console.Write("Введите диаметр окружности: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            double p = 3.14;
            double L = p * a;
            Console.WriteLine(L);
        }
    }
}
