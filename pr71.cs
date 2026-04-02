using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    internal class Program
    {
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Status { get; set; }

            public User(string name, int age, string status)
            {
                Name = name;
                Age = age;
                Status = status;
            }
            
            public override string ToString()
            {
                return $"{Name}, {Age}, {Status}";
            }

            public static List<User> FlterUsers(List<User> users, Predicate<User> condition)
            {
                return users.FindAll(condition);
            }
        }

        static void Main(string[] args)
        {
            List<User> userList = new List<User>
            {
                new User("Алиса", 25, "Активен"),
                new User("Боб", 17, "Активен"),
                new User("Чарли", 30, "Забанен"),
                new User("Диана", 22, "Активен"),
                new User("Егор", 19, "Забанен"),
                new User("Фёдор", 45, "Активен")
            };

            List<User> adults = User.FlterUsers(userList, user => user.Age >= 18);
            
            foreach (var user in adults)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine();

            List<User> bannedUsers = User.FlterUsers(userList, user => user.Status == "Забанен");

            foreach (var user in bannedUsers)
            { 
            Console.WriteLine(user);
            }
            Console.WriteLine();

            List<User> activeYoung = User.FlterUsers(userList, user => user.Status == "Активен" && user.Age >= 18);
            
            foreach (var user in activeYoung)
            {
                Console.WriteLine(user);
            }
        }
    }
}
