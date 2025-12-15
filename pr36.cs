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
        string firstname;
        string lastname;
        string gender;
        byte age;
        short height;
        short weight;

        public Person(string _firstname, string _lastname)
        {
            firstname = _firstname;
            lastname = _lastname;
        }

        public void print()
        {
            Console.WriteLine($"{firstname} {lastname} {gender} {age} {height} {weight}");

            Console.WriteLine($"{firstname} {lastname}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            Person firstStudent = new Person('Бандеровский' 'Илья');
            Person secondStudent = new Person('Гладких' 'Иван');
            firstStudent.print();
            secondStudent.print();
        }
    }
}
