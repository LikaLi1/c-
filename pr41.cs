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
            Console.WriteLine("Введите сумму дохода: ");
            Int32.TryParse(Console.ReadLine(), out int A);

            if (A < 50000)
            {
                Console.WriteLine((A * 13) / 100);
            }
            else if (A >= 50000 && A <= 100000)
            {
                Console.WriteLine((A * 15) / 100);
            }
            else if(A > 100000)
            {
                Console.WriteLine((A * 20) / 100);
            }
        }
    }
}
