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
            Console.Write("Введите ширину: ");
            Int32.TryParse(Console.ReadLine(), out int A);
            Console.Write("Введите высоту: ");
            Int32.TryParse(Console.ReadLine(), out int B);
            int S = A * B;
            Console.WriteLine(S);
            Console.WriteLine("Введите ширину: ");
            Int32.TryParse(Console.ReadLine(), out int C);
            Console.Write("Введите высоту: ");
            Int32.TryParse(Console.ReadLine(), out int D);
            int P = 2 * (C + D);
            Console.WriteLine(P);
        }
    }
}
