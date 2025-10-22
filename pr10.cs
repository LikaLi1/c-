using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            Int32.TryParse(Console.ReadLine(), out int A);

            long fact = 1;
            double sum = 0;

            for (int i = 1; i <= A; i++) 
            {
                fact *= i;
                sum += fact;

            }
            Console.WriteLine(sum);
        }
    }
}
