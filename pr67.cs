using System;

namespace ConsoleApp3
{
    delegate decimal CheckCalculator(decimal price);
    class Calculator
    {
        public decimal Price { get; set; }
    }

    internal class Program
    {
        static CheckCalculator CreateCalculator(decimal discountPercent)
        {
            return delegate (decimal price)
            {
                return price * (1 - discountPercent / 100);
            };
        }
        static void Main(string[] args)
        {
            CheckCalculator NovCalc = CreateCalculator(5);
            CheckCalculator VipCalc = CreateCalculator(20);

            decimal price = 1000;

            Console.WriteLine($"Скидка для новичка 5%: {NovCalc(price)}");
            Console.WriteLine($"Скидка для VIP 20%: {VipCalc(price)}");
        }
    }
}
