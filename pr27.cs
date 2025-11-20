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

            Console.Write("Введите первое число K: ");
            Int32.TryParse(Console.ReadLine(), out int K);

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
                Console.WriteLine($"Элемент {i + 1} строки: {arr[i, K - 1]}");
            }
        }
    }
}
