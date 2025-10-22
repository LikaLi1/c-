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
            Console.Write("Введите число: ");
            Int32.TryParse(Console.ReadLine(), out int A);
            Console.Write("Введите степень: ");
            Int32.TryParse(Console.ReadLine(), out int N);
            int t = A;
            for(int i = 1; i < N; i++)
            {
                A *= t;           
            }
            Console.Write(A);
        }
    }
}
