using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"До: a = {a}, b = {b}");

        Swap(ref a, ref b);

        Console.WriteLine($"После: a = {a}, b = {b}");
    }

    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
