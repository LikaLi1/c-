using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static int a(int[] K, int N)
        {
            if (N < 0 || N >= K.Length)
            {
                return -1;
            }
            return K[N];
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(a(arr, 1));
        }
    }
}
