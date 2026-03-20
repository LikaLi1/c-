namespace Proga
{
    interface IHuman
    {
        int? time {  get; set; }
        void sleep()
        {
            Console.WriteLine($"Человек спит по {time} минут");
        }
    }
    class Student : IHuman
    {
        public int? time { get; set; }
        public void sleep()
        {
            Console.WriteLine($"Студент спит по {time} минут");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.time = 60;
            student.sleep();

            IHuman m = new Student();
        }
    }
}
