using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int a);

            if (a % 2 == 0)
            {
                Console.WriteLine("Делит на 2");
            }
            else
            {
                Console.WriteLine("Не делит на 2");
            }
        }
    }
}
