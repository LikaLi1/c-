using Pay;
using System;

namespace Pay
{
    interface IPaymentMethod
    {
        bool Pay(decimal amount);
    }
    class CardPaymet : IPaymentMethod
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Оплата картой прошла");
            return true;
        }
    }
    class CryptoPayment : IPaymentMethod
    {
        public decimal amount { get; set; }
        public bool Pay(decimal amount)
        {
            Console.WriteLine($"Транзакция в блокчейне подтверждена");
            return true;
        }
    }
    class Order
    {
        public int num_order { get; set; }
        public decimal amount { get; set; }
        public string? status { get; set; }

        public static event Action<Order>? OnStatusChanged;

        public void Process(IPaymentMethod method)
        {
            if (method.Pay(amount))
            {
                this.status = "Оплачен";
                OnStatusChanged?.Invoke(this);
            }
            else
            {
                this.status = "Ошибка оплаты";
                OnStatusChanged?.Invoke(this);
            }
        }
    }
    static class Subscribers
    {
        public static void EmailService(Order order)
        {
            Console.WriteLine("Письмо отправлено: ваш заказ номер.... в пути");
        }
        public static void WarehouseApp(Order order)
        {
            Console.WriteLine("Склад: товар зарегестрирован для заказа номер....");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CardPaymet card = new CardPaymet();
            CryptoPayment crypto = new CryptoPayment();
            Order order = new Order
            {
                num_order = 44,
                amount = 500
            };

            Order.OnStatusChanged += Subscribers.EmailService;
            Order.OnStatusChanged += Subscribers.WarehouseApp;

            order.Process(card);
        }
    }
}
