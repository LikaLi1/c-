using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            Console.Write("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.Write("Введите второе число: ");
            Int32.TryParse(Console.ReadLine(), out int b);
            int sum = 0;
            for (int i = a; i <= b; i++) { 
            sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
