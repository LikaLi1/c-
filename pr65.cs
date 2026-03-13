namespace ConsoleApp3
{
    delegate void CardHandler(string text);
    class Card
    {
        public event CardHandler? Notify;
        public int Balance {  get; set; }
        public Card(int balance) => Balance = balance;
        public void Add(int sum) => Balance += sum;
        public void Take(int sum)
        {
            if (Balance >= sum)
            {
                Balance = sum;
            }
            Notify?.Invoke("Деньги списаны");
        }
    }

    internal class Program
    {
        static void SendEmail(string text)
        {
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            Card card = new Card(90451);
            card.Notify += SendEmail;
            card.Take(1500);
        }
    }
}
