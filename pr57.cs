using System;
using System;

namespace ConsoleApp5
{
    class Car
    {
        public string brand { get; set; }
        private string model { get; set; }
        int year { get; set; }
        double engineVolume { get; set; }
        bool isRunning { get; set; }
        int currentSpeed { get; set; }

        public Car(string _brand, string _model, int _year, double _engineVolume)
        {
            brand = _brand;
            model = _model;
            year = _year;
            engineVolume = _engineVolume;
            isRunning = false;
            currentSpeed = 0;
        }

        public void StartEngine() 
        { 
            if(!isRunning)
            {
                isRunning = true;
                Console.WriteLine("Машина завелась");
            }
            else
            {
                Console.WriteLine("Машина не завелась");
            }
        }

        public void StopEngine()
        {
            if (isRunning)
            {
                isRunning = false;
                currentSpeed = 0;
                Console.WriteLine("Машина остановилась");
            }
            else
            {
                Console.WriteLine("Машина уже остановлена");
            }
        }

        public void Accelerate(int speed)
        {
            if (isRunning)
            {
                currentSpeed += speed;
                Console.WriteLine($"Скорость автомобиля = {currentSpeed}");
            }
            else
            {
                Console.WriteLine("Заведите машину");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"марка автомобиля : {brand}");
            Console.WriteLine($"модель автомобиля : {model}");
            Console.WriteLine($"год выпуска : {year}");
            Console.WriteLine($"объем двигателя в литрах : {engineVolume}");
            Console.WriteLine($"состояние автомобиля : {isRunning}");
            Console.WriteLine($"скорость автомобиля : {currentSpeed}");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Car c1 = new Car("Toyota", "Corolla", 2020, 1.8);
                Car c2 = new Car("Toyota", "Corolla", 2020, 1.8);
                Car c3 = new Car("Toyota", "Corolla", 2020, 1.8);

                c1.DisplayInfo();

                c1.StartEngine();
                c1.StopEngine();
                c1.Accelerate(70);

                c2.DisplayInfo();
                
                c2.StartEngine();
                c2.StopEngine();
                c2.Accelerate(20);

                c3.DisplayInfo();

                c3.StartEngine();
                c3.StopEngine();
                c3.Accelerate(10);
            }
        }
    }
}
