namespace ConsoleApp12
{
    internal class Program
    {
        class ServerEventArgs : EventArgs
        {
            public int Value { get; set; }
            public string Message { get; set; }

        }
        class ServerMonitor
        {
            public event EventHandler<ServerEventArgs> ThresholdReached;
            protected virtual void Onchanged(int value)
            {
                ThresholdReached?.Invoke(this, new ServerEventArgs { Value = value, Message = "Hi" });
            }
            public void Start()
            {
                int value = 0;
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    value = rnd.Next(0, 101);
                }
                if (value > 80)
                {
                    Onchanged(value);
                }
            }
        }

        public class Logger
        {
            public string? Name { get; set; }

            public void show(object serves, EventArgs e)
            {
                Console.WriteLine($"Имя логгера: {Name}");
            }
        }
        static void Main(string[] args)
        {
            Logger log = new Logger();
            ServerMonitor serverMonitor = new ServerMonitor();

            serverMonitor.ThresholdReached += log.show;
            serverMonitor.Start();
        }
    }
}
