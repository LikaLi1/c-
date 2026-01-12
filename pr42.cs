using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDays = 7;
            int[] arr = new int[countDays];
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.Write($"Введите значение для дня {i + 1}: ");
                Int32.TryParse(Console.ReadLine(), out int val);
                arr[i] = val;
            }

            double AveVal = arr.Average();
            Console.WriteLine($"Среднее значение: {AveVal}");

            int minVal = arr[0];
            int maxVal = arr[0];

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] < minVal)
                {
                    minVal = arr[i];
                }
                if (arr[i] > maxVal)
                {
                    maxVal = arr[i];
                }
            }

            Console.WriteLine($"Минимальное значение температуры: {minVal}");

            Console.WriteLine($"Максимальное значение температуры: {maxVal}");
        }
    }
}
