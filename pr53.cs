using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            bool parsed = int.TryParse(Console.ReadLine(), out int N);

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
