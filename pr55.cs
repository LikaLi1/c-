using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i > -1)
            {
                Console.Write("Введите число: ");
                if (Int32.TryParse(Console.ReadLine(), out i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Конец");
        }
    }
}
