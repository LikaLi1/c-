using System;
using System.Numerics;

class WeatherJournal
{
    private int size = 7;
    private double[] t = new double[size];

    public double this[int index]
    {
        get
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Бе");
            }
            return t[index];
        }

        set
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Бе");
            }
            if (value <= -50 || value >= 50)
            {
                t[index] = 0;
            }
            else
            {
                t[index] = value;
            }
        }
    }
    static void Main(string[] args)
    {
        WeatherJournal journal = new WeatherJournal();

        journal[0] = 20;
        journal[1] = -60;

        Console.WriteLine(journal[0]);
        Console.WriteLine(journal[1]);
    }
}
