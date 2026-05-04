using ConsoleApp17;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public Student(string? name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>()
            {
                new Student("Vadim", 18),
                new Student("Maxim", 18)
            };
            students.CollectionChanged += StudentChanged;

            students.Add(new Student("Alex", 18));
            students.Add(new Student("Alex", 18));
            students.Add(new Student("Alex", 18));

            void StudentChanged(object? sender, NotifyCollectionChangedEventArgs e)
            {
                if (e.NewItems?[0] is Student newStudent)
                {
                    Console.WriteLine("Add");
                    foreach (var student in e.NewItems)
                    {
                        Console.WriteLine(student);
                    }
                }
            } 
        }
    }
}


Index a = ^1;
Range b = 3..^0; // с 3 до последнего

Console.WriteLine(b);

List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> c = list[b];

Console.WriteLine(list[a]);
