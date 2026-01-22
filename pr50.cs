using System;
using System.ComponentModel.Design;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст: ");
            Int32.TryParse(Console.ReadLine(), out int a);

            if (a < 18)
            {
                Console.WriteLine("Вы не можете получить прова");
            }
            else
            {
                Console.WriteLine("Вы можете получить права");
            }
        }
    }
}
