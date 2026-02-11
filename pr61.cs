using System;

class WeatherJournal
{
    private double[] temperatures = new double[7];

    public double this[int index]
    {
        get
        {
            if (index >= 0 && index < temperatures.Length)
            {
                return temperatures[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Не подходит");
            }
        }
        set
        {
            if (index >= 0 && index < temperatures.Length)
            {
                if (value < -50 || value > 50)
                {
                    temperatures[index] = 0;
                }
                else
                {
                    temperatures[index] = value;
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Не подходит");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        var weekTemps = new WeatherJournal();

        weekTemps[0] = 20.5;
        weekTemps[1] = -55;
        weekTemps[2] = 25.1;
        weekTemps[3] = 45.2;
        weekTemps[4] = 60;
        weekTemps[5] = -10;
        weekTemps[6] = 15;

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"День {i + 1}: {weekTemps[i]}°C");
        }
    }
}
