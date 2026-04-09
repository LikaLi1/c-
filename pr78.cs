using System;

namespace ConsoleApp2
{
    internal class Program
    {
        class Vector2
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Vector2(int x, int y)
            {
                X = x;
                Y = y;
            }
            public static Vector2 operator +(Vector2 x, Vector2 y)
            {
                return new Vector2(x.X + y.X, y.Y + x.Y);
            }
            static void Main(string[] args)
            {
                Vector2 x = new Vector2(12, 5);
                Vector2 y = new Vector2(2, 9);
                Vector2 c = x + y;
                Console.WriteLine($"{c.X} {c.Y}");
            }
        }
    }
}
