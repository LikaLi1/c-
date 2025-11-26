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

        static long MaxA(int A, int B)
        {
            if(A > B)
            {
                return A;
            } else 
            {
                return B;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int A);
            Console.WriteLine("Введите второе число: ");
            Int32.TryParse(Console.ReadLine(), out int B);

            Console.WriteLine(MaxA(A, B));
        }
    }
}
