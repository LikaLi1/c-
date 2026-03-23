using Pay;
using System;

namespace Pay
{
    interface implement
    {
        decimal? money { get; set; }
        void conclusion()
        {
            Console.WriteLine($"Вывод денежных средств в размере: {money}");
        }
    }
    class CreditCardPayment : implement
    {
        public decimal? money { get; set; }
        public void conclusion() 
        {
            Console.WriteLine($"Вывод кредитных денежных средств в размере: {money}");
        }
    }
    class PayPalPayment : implement
    {
        public decimal? money { get; set; }
        public void conclusion() 
        {
            Console.WriteLine($"Вывод электронных денежных средств в размере: {money}");
        }
    }
    class CryptoPayment : implement
    {
        public decimal? money { get; set; }
        public void conclusion()
        {
            Console.WriteLine($"Вывод ненастоящих денежных средств в размере: {money}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment credit = new CreditCardPayment();
            credit.money = 2000;
            credit.conclusion();

            implement m = new CreditCardPayment();
        }
    }
}
