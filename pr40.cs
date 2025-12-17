using System;

namespace ConsoleApp4
{
    class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Sub(double a, double b) => a - b;
        public double Mul(double a, double b) => a * b;
        public double Div(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
