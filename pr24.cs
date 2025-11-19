using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {

        static double circleS(double R)
            {
                const double pi = 3.14;
                return pi * R * R;
            }

        static void Main(string[] args)
        {
        Console.Write("Введите первый радиус: ");
        double.TryParse(Console.ReadLine(), out double R1);

        Console.Write("Введите первый радиус: ");
        double.TryParse(Console.ReadLine(), out double R2);

        Console.Write("Введите первый радиус: ");
        double.TryParse(Console.ReadLine(), out double R3);

        double S1 = circleS(R1);
        double S2 = circleS(R2);
        double S3 = circleS(R3);

        Console.WriteLine($"Площадь круга радиуса {R1} равна {S1}");
        Console.WriteLine($"Площадь круга радиуса {R2} равна {S2}");
        Console.WriteLine($"Площадь круга радиуса {R3} равна {S3}");
        }
    }
}
