using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Шахматная доска");

            for (int a = 0; a < 8; a++)
            {
                for (int b = 0; b < 8; b++)
                {
                    if ((a + b) % 2 == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine(); 
            }
        }
    }
}
