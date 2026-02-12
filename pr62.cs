using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = 3;
            int N = 3;
            int[,] arr = new int[M, N];
            Random rnd = new Random();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = rnd.Next(1, 11);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{arr[i, j],3} ");
                }
                Console.WriteLine();
            }

            int maxInArr = arr[0, 0];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (arr[i, j] > maxInArr)
                    {
                        maxInArr = arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Максимальный элемент в матрице: {maxInArr}");

            int maxOfMins = int.MinValue;
            for (int i = 0; i < M; i++)
            {
                int rowMin = arr[i, 0];
                for (int j = 1; j < N; j++)
                {
                    if (arr[i, j] < rowMin)
                        rowMin = arr[i, j];
                }
                Console.WriteLine($"Минимальный элемент строки {i + 1}: {rowMin}");
                if (rowMin > maxOfMins)
                {
                    maxOfMins = rowMin;
                }
            }
            Console.WriteLine($"Максимальный среди минимальных элементов строк: {maxOfMins}");
        }
    }
}
