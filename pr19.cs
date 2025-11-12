using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число, > 0: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            int[] bbb = new int[a];
            for (int i = 0; i < a; i++)
            {
                bbb[i] = (int)Math.Pow(2, i+1);
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"{bbb[i]}");
            }
        }
    }
}

