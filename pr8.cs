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
            Console.Write("Введите второе число: ");
            Int32.TryParse(Console.ReadLine(), out int N);
            
            float sum = 0f;

            for (int i = 1; i <= N; i++) 
            { 
                sum += 1/(float)i;
            }
            Console.WriteLine(sum);
        }
    }
}
