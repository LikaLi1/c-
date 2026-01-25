using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            if (Int32.TryParse(Console.ReadLine(), out int a))
            {
                int count = 1;
                while (count <= 10)
                {
                    Console.WriteLine($"{a} x {count} = {a * count}");
                    count++;
                }
            }
        }
    }
}
