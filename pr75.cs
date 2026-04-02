using System;

namespace Proga
{
    class Seat
    {
        public decimal Price {  get; set; }
        public bool IsBooked { get; set; }
        public Seat(decimal price)
        {
            Price = price;
            IsBooked = false;
        }
    }
    class CinemaHall
    {
        private Seat[,] seats = new Seat[5, 10];
        public CinemaHall()
        {
            for (int row 0; row < seats.GetLength(0); row++)
            {
                for (int col 0; col < seats.GetLength(0); col++)
                {
                    decimal price;
                    if (row == 0 && row == 1)
                    {
                        price = 100;
                    }
                    else if (row > 1 && row <= 6)
                    {
                        price = 500;
                    }
                    else if (row > 6 && row <= 10)
                    {
                        price = 300;
                    }
                    else if (row > 10 && row <= 15)
                    {
                        price = 100;
                    }

                    seats[row, col] = new Seat(price);
                }
            }
        }
    }
    static void Main()
        {

        }
    }
}
