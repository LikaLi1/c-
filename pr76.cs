namespace ConsoleApp18
{
    class Human : ICloneable
    {
        public string Name { get; set; }  
        public Hand hand { get; set; }
        public Human(string name, Hand h)
        {
            Name = name;
            hand = hand;
        }
        public object Clone()
        {
            return new Human(Name, new Hand { countFingers = hand.countFingers});
        } 
    }
    class Hand
    {
        public int countFingers { get; set; }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("hello", new Hand { countFingers = 5 });
            Human h2 = (Human)h1.Clone();
            Console.WriteLine(h1.hand.countFingers);
            Console.WriteLine(h2.hand.countFingers);
        }
    }
}
