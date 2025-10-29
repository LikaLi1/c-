using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write("   ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine(); 
            }
        }
    }
}
