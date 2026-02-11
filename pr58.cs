using System;

namespace Student
{
    class Student
    {
        public string Name { get; }
        public int Age { get; set; }

        private double _GPA;
        public double GPA
        {
            get => _GPA;
            set
            {
                if (value < 0.0 || value > 4.0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Значение GPA должно быть в диапазоне от 0.0 до 4.0");
                }
                _GPA = value;
            }
        }


        public Student(string _Name, int _Age, double _Gpa)
        {
            Name = _Name;
            Age = _Age;
            GPA = _Gpa;
        }

        public void proverka()
        {
            bool inRange = (GPA >= 0.0 && GPA <= 4.0);
            if (inRange)
            {
                Console.WriteLine("Средний балл студента не находится в диапазоне");
            }
            else
            {
                Console.WriteLine("Средний балл студента в пределах допустимого диапазона");
            }
        }
    }


    class Program
    {
        static void Main()
        {
            try
            {
                Student s = new Student("Иван", 20, 3.5);
                Console.WriteLine($"Имя: {s.Name}, Возраст: {s.Age}, GPA: {s.GPA}");
                s.proverka();

                s.GPA = 4.5;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }
    }
}
