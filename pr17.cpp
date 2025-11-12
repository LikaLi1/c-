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
            Console.Write("Введите первое число: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.Write("Введите второе число: ");
            Int32.TryParse(Console.ReadLine(), out int b);
            Console.Write("Введите символ операции(+, -, *, /): ");
            char.TryParse(Console.ReadLine(), out char c);
            if (c == '+')
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            else if (c == '-')
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }
            else if (c == '*')
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }
            else if (c == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    Console.WriteLine($"{a} / {b} = {a / b}");
                }
            }
            else
            {
                Console.WriteLine("Неизвестная операция");
            }
            Console.WriteLine("");
        }
    }
}

