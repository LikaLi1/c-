namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, string> users = new Dictionary<string, string>(16, StringComparer.OrdinalIgnoreCase)
            {
                ["Никита"] = "86572549988",
                ["Саша"] = "84521569521",
                ["Маша"] = "86523457736",
                ["Валера"] = "86841255445"
            };

            while (true)
            {
                Console.WriteLine("\nВведите ваше следующее действие:");
                Console.WriteLine("0 - Добавить контакт");
                Console.WriteLine("1 - Найти контакт");
                Console.WriteLine("2 - Удалить контакт");
                Console.WriteLine("3 - Показать всё");
                Console.WriteLine("4 - Выйти из программы");

                if (!int.TryParse(Console.ReadLine(), out int choose))
                {
                    Console.WriteLine("Ошибка");
                    continue;
                }

                switch (choose)
                {
                    case 0:
                        Console.Write("Введите имя: ");
                        string nameInput = Console.ReadLine().Trim();

                        if (string.IsNullOrWhiteSpace(nameInput))
                        {
                            Console.WriteLine("Ошибка: имя не может быть пустым");
                            break;
                        }

                        if (users.ContainsKey(nameInput))
                        {
                            Console.WriteLine("Ошибка");
                            break;
                        }

                        Console.Write("Введите телефон: ");
                        string phoneInput = Console.ReadLine().Trim();

                        users.Add(nameInput, phoneInput);
                        Console.WriteLine($"Контакт {nameInput} успешно добавлен");
                        break;

                    case 1:
                        Console.Write("Введите имя для поиска: ");
                        string searchInput = Console.ReadLine().Trim();

                        if (users.TryGetValue(searchInput, out string foundPhone))
                        {
                            Console.WriteLine($"Найден телефон: {foundPhone}");
                        }
                        else
                        {
                            Console.WriteLine("Имя не найдено в словаре");
                        }
                        break;
                }
            }
        }
    }
}
