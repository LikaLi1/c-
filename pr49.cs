using System;
using System.ComponentModel.Design;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.Write("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int b);

            if (a < b)
            {
                Console.WriteLine(b);
            }
            else if (a == b)
            {
                Console.WriteLine("Равные");
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
