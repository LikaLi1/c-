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

        public string getlastname()
        {
            return lastname;
        }

        public void setlastname(string newname)
        {
            lastname = newname;
        }

        public void print()
        {
            Console.WriteLine($"{firstname} {lastname} {age} {experience}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person Student = new Person("Дмитрий", "Биценко", 42, 15);
            Student.getlastname();
            Student.setlastname("AAA");
            Student.print();
        }
    }
}
