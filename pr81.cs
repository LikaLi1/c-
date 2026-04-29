
Dictionary<string, string> users = new Dictionary<string, string>(16) //ёмкость словаря
{
    ["id_1"] = "user_1",
    ["id_2"] = "user_2",
    ["id_3"] = "user_3",
};

KeyValuePair<string, string> a = new KeyValuePair<string, string>("id_1", "user_1"); //плучаем значение

Console.WriteLine(users["id_1"]);

foreach (var user in users)
{
    Console.WriteLine(user);
}

foreach (var user in users)
{
    Console.WriteLine($"{user.Key} - {user.Value} ");
}

foreach (var (key, val) in users)
{
    Console.WriteLine($"{key} - {val} ");
}
