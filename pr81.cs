
Dictionary<string, string> users = new Dictionary<string, string>(16) //ёмкость словаря
{
    ["id_1"] = "user_1",
    ["id_2"] = "user_2",
    ["id_3"] = "user_3"
};

Dictionary<string, string> d = new Dictionary<string, string>() //ёмкость словаря
{
    ["id_4"] = "user_1",
    ["id_5"] = "user_2",
    ["id_6"] = "user_3"
};

users.Add("id_8", "hi");
//users.TryAdd("id_1", "hello"); //попытка создания существующего объекта
//Console.WriteLine(users.TryGetValue(users["id_7"], out string? text)); //проверка на существование
users.Remove("id_3");

KeyValuePair<string, string> a = new KeyValuePair<string, string>("id_1", "user_1"); //плучаем значение

Console.WriteLine(users["id_1"]);

Console.WriteLine();
foreach (var user in users)
{
    Console.WriteLine(user);
}

Console.WriteLine();
foreach (var user in users)
{
    Console.WriteLine($"{user.Key} - {user.Value} ");
}

Console.WriteLine();
foreach (var (key, val) in users)
{
    Console.WriteLine($"{key} - {val} ");
}

Console.WriteLine();
foreach (var val in users.Values)
{
    Console.WriteLine(val);
}
