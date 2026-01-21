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
            Console.Write("Введите имя: ");
            string N = Console.ReadLine();

            Console.Write("Введите возраст: ");
            Int32.TryParse(Console.ReadLine(), out int A);

            Console.WriteLine($"Привет, {N}! Тебе {A} лет");
        }
    }
}
