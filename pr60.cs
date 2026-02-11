using System;

class ToDoList
{
    private string[] tasks = new string[5];

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < tasks.Length)
                if (tasks[index] != null)
                    return tasks[index];
                else
                    return "Задачи нет";
            else
                return "Задачи нет";
        }
        set
        {
            if (index >= 0 && index < tasks.Length)
                tasks[index] = value;
            else
                Console.WriteLine("Ошибка");
        }
    }
}

class Program
{
    static void Main()
    {
        ToDoList myList = new ToDoList();

        myList[0] = "C++";
        myList[1] = "C#";
        myList[2] = "SQL";

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Задача {i}: {myList[i]}");
        }
    }
}
