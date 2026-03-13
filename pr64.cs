namespace ConsoleApp3
{
    delegate void TemperatureHandler(int temperature);
    class Thermostat
    {
        public event TemperatureHandler? Overheat;
        public int temperature { get; set; }
        public Thermostat(int temp) => temperature = temp;
        public void SetTemperature()
        {
            if (temperature > 80)
            {
                Overheat?.Invoke(temperature);
            }
        }
    }

    internal class Program
    {
        static void StartSiren(int t)
        {
            Console.WriteLine($"Высокая температура, запуск сирены, {t} градусов");
        }
        static void SendAlert(int t)
        {
            Console.WriteLine($"Предупреждение! Не перегревайте систему, {t} градусов");
        }
        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat(9);
            thermostat.Overheat += StartSiren;
            thermostat.Overheat += SendAlert;
            thermostat.temperature = 81;

            thermostat.SetTemperature();
        }
    }
}
