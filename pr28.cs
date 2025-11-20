using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число M: ");
            Int32.TryParse(Console.ReadLine(), out int M);

            Console.Write("Введите первое число N: ");
            Int32.TryParse(Console.ReadLine(), out int N);

            Random rnd = new Random();

            int[,] arr = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = rnd.Next(0, 99); 
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{arr[i, j], 5} ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < M; i++)
            {
                int sum = 0;
                for (int j = 0; j < N; j++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine($"Строка {i + 1}: сумма = {sum}");
            }
        }
    }
}
