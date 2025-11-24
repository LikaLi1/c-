using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static double a(int A, int B, int C, out double x1, out double x2)
        {
            double d;
            d = B * B - 4 * A * C;
            if (d > 0)
            {
                x1 = (-B + Math.Sqrt(d)) / 2;
                x2 = (-B + Math.Sqrt(d)) / 2;
            }
            else if (d == 0)
            {
                x1 = (-B + Math.Sqrt(d)) / 2;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int.TryParse(Console.ReadLine(), out int A);

            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out int B);

            Console.Write("Введите третье число: ");
            int.TryParse(Console.ReadLine(), out int C);
        }
    }
}
