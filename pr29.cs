using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {

        static int SumRange(int A, int B)
        {
            if (A > B)
            {
                return 0;
            }

            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }
            return sum;
        }
            static void Main(string[] args)
            {

                Console.Write("Введите первое число: ");
                int.TryParse(Console.ReadLine(), out int A);

                Console.Write("Введите второе число: ");
                int.TryParse(Console.ReadLine(), out int B);

                Console.Write("Введите третье число: ");
                int.TryParse(Console.ReadLine(), out int C);

                int sum_1 = SumRange(A, B);
                int sum_2 = SumRange(B, C);

                Console.WriteLine($"От числа {A} до число {B} сумма равна {sum_1}");
                Console.WriteLine($"От числа {B} до число {C} сумма равна {sum_2}");
            }
    }
}

