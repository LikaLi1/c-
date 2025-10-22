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
            Int32.TryParse(Console.ReadLine(), out int a);
            int temp = a / 100;
            Console.Write("Первая цифра: ");
            Console.WriteLine(temp);
        }
    }
}
