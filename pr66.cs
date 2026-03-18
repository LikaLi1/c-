namespace ConsoleApp14
{
    internal class Program
    {
        static double UpdatePrice(double oldPrice, Func<double, double> strategy) => strategy(oldPrice);
        static void Main(string[] args)
        {
            Console.WriteLine($"Скидка 20%: {UpdatePrice(500, a => a * 0.8)}");
        }
    }
}
