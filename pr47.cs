using System;

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

            Console.Write("Введите третье число: ");
            Int32.TryParse(Console.ReadLine(), out int c);

            Console.WriteLine($"Сумма чисел = {a + b + c}");
        }
    }
}
