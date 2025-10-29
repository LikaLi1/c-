using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i * 2 + 1;
            }

            for (int i = 0; i < a.Length; i++) 
            { 
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine("");

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
        }
    }
}
