using System;

namespace Proga
{
    class Seat
    {
        public decimal Price { get; set; }
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
        public event Action OnHallFull;
        public Action<string> History;

        public CinemaHall()
        {
            for (int row = 0; row < seats.GetLength(0); row++)
            {
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    decimal price;
                    if (row == 0 || row == 1)
                    {
                        price = 100;
                    }
                    else if (row == 2 || row == 3)
                    {
                        price = 500;
                    }
                    else
                    {
                        price = 600;
                    }

                    seats[row, col] = new Seat(price);
                }
            }
        }

        public void ShowAvailable(Predicate<Seat> filter)
        {
            bool found = false;
            for (int row = 0; row < seats.GetLength(0); row++)
            {
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    Seat seat = seats[row, col];
                    if (filter(seat))
                    {
                        Console.WriteLine($"Ряд {row + 1}, Место {col + 1}");
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Нет подходящих мест.");
            }
        }

        public bool TryBook(int row, int col, Func<int, int, decimal, decimal> priceNew)
        {
            if (row < 0 || row >= seats.GetLength(0) || col < 0 || col >= seats.GetLength(1))
            {
                History?.Invoke($"Ошибка: Ряд {row + 1} или место {col + 1} не существует");
                return false;
            }

            Seat seat = seats[row, col];
            if (seat.IsBooked)
            {
                History?.Invoke($"Ошибка: Ряд {row + 1}, Место {col + 1} уже забронировано");
                return false;
            }

            decimal finalPrice = priceNew(row, col, seat.Price);
            seat.IsBooked = true;
            History?.Invoke($"Ряд {row + 1}, Место {col + 1} забронировано за {finalPrice} руб.");

            if (IsHallFull())
            {
                OnHallFull?.Invoke();
            }
            return true;
        }

        private bool IsHallFull()
        {
            foreach (var seat in seats)
            {
                if (!seat.IsBooked)
                    return false;
            }
            return true;
        }
    }

    class Program
    {
        static void Main()
        {
            CinemaHall hall = new CinemaHall();
            List<string> log = new List<string>();
            hall.History = message =>
            {
                log.Add(message);
                Console.WriteLine(message);
            };

            hall.OnHallFull += () =>
            {
                Console.WriteLine("Внимание! Зал полностью забронирован.");
                log.Add("Зал полностью забронирован.");
            };

            Console.WriteLine("Все свободные места:");
            hall.ShowAvailable(s => !s.IsBooked);

            Console.WriteLine("");

            Console.WriteLine("Свободные места дешевле 400 руб.:");
            hall.ShowAvailable(s => !s.IsBooked && s.Price < 400);

            Func<int, int, decimal, decimal> priceN = (row, col, baseP) =>
            {
                decimal price = baseP;

                if (row == 4)
                {
                    price *= 1.2m;
                    //для посчётов в виде decimal
                }

                if (col >= 0 && col <= 2)
                {
                    price *= 0.9m; 
                    //для посчётов в виде decimal
                }

                return Math.Round(price, 2);
            };

            hall.TryBook(4, 0, priceN);
            hall.TryBook(0, 5, priceN);
            hall.TryBook(10, 0, priceN);
        }
    }
}
