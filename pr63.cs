namespace ConsoleApp5
{
    internal class Program
    {
        class Array<T>
        {
            private T[] array;
            private int count;
            public Array(int size)
            {
                array = new T[size];
            }
            public void Add(T value)
            {
                array[count++] = value;
            }
        }
        static void Print(string text, Action<string> a)
        {
            a(text);
        }
        static void Test<T>(T text)
        {
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            Array<int> a = new Array<int>(5);
            Array<bool> b = new Array<bool>(5);

            Print("aaaa", (x) => Console.WriteLine($"[ERROR!] [{DateTime.Now}] : {x}"));
            Print("aaaa", (x) => Console.WriteLine($"[ERROR!] : {x}!!!"));
            Print("aaaa", (x) => Console.WriteLine($"[LOG] [{DateTime.Now}] : {x}"));

            Test<string>("aaaa");

            Action c = () => Console.WriteLine(1);
        }
    }
}
