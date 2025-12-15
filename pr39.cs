using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Person
    {
        public string firstname;
        private string lastname;
        byte age;
        int experience;

        public Person(string _firstname, string _lastname, byte _age, int _experience)
        {
            firstname = _firstname;
            lastname = _lastname;
            age = _age;
            experience = _experience;
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public void print()
        {
            Console.WriteLine($"{firstname} {lastname} {age} {experience}");
        }
    }

    class Avto
    {
        public string color;
        public string brand;
        public int speed;
        public int mileage;
        public int numberDoors;
        Person driver;

        public Avto(string _color, string _brand, byte _speed, int _mileage, int _numberDoors, Person _driver)
        {
            color = _color;
            brand = _brand;
            speed = _speed;
            mileage = _mileage;
            numberDoors = _numberDoors;
            driver = _driver;
        }
        public void print()
        {
            Console.WriteLine($"{color} {brand} {speed} {mileage} {numberDoors} {driver}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person driver = new Person("Иван", "Иванов", 30, 5);
            Avto car = new Avto("Красный", "Toyota", 120, 20000, 4, driver);
            driver.print();

            Console.WriteLine("Машина:");
            Console.WriteLine($"Цвет: {car.color}");
            Console.WriteLine($"Бренд: {car.brand}");
            Console.WriteLine($"Скорость: {car.speed}");
            Console.WriteLine($"Пробег: {car.mileage}");
            Console.WriteLine($"Количество дверей: {car.numberDoors}");
        }
    }
}
