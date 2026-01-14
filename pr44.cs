using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Film
    {
        private string title;
        int year;
        public string genre;
        public string description;

        public Film(string _title, int _year, string _genre, string _description)
        {
            title = _title;
            year = _year;
            genre = _genre;
            description = _description;
        }

        public void print()
        {
            Console.WriteLine($"{title} {year} {genre} {description}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Film fil = new Film("Оно", 2017, "ужасы", "Когда в городке Дерри, штат Мэн, начинают пропадать дети, несколько ребят сталкиваются со своими величайшими страхами");
            fil.print();
        }
    }
}
