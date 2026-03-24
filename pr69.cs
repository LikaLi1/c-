using Pay;
using System;

namespace Pay
{
    interface IPay
    {
        decimal? money { get; set; }
        void conclusion();
    }
    class CreditCardPayment : IPay
    {
        public decimal? money { get; set; }
        public void conclusion()
        {
            Console.WriteLine($"Вывод кредитных денежных средств в размере: {money}");
        }
    }
    class PayPalPayment : IPay
    {
        public decimal? money { get; set; }
        public void conclusion()
        {
            Console.WriteLine($"Вывод электронных денежных средств в размере: {money}");
        }
    }
    class CryptoPayment : IPay
    {
        public decimal? money { get; set; }
        public void conclusion()
        {
            Console.WriteLine($"Вывод ненастоящих денежных средств в размере: {money}");
        }
    }
    class PaymentProcessor
    {
        private IPay _pay;
        public PaymentProcessor(IPay pay)
        {
            _pay = pay;
        }
        public void ProcessorPayment(decimal money)
        {
            _pay.money = money;
            _pay.conclusion();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment credit = new CreditCardPayment();
            PayPalPayment paypal = new PayPalPayment();
            CryptoPayment crypto = new CryptoPayment();

            var process = new PaymentProcessor(credit);
            process.ProcessorPayment(500);

            var processs = new PaymentProcessor(paypal);
            process.ProcessorPayment(10000);

            var processss = new PaymentProcessor(crypto);
            process.ProcessorPayment(10);
        }
    }
}
