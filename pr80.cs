using System;

public record Resourse(string Name, int Quantity)
{
    public static Resourse operator +(Resourse r1, Resourse r2)
    {
        if (r1.Name != r2.Name)
        {
            throw new InvalidOperationException("Разные ресурсы");
        }
        else
        {
            return new Resourse(r1.Name, r1.Quantity + r2.Quantity);
        }
    }
}

class Proga
{
    static void Main()
    {
        var gold_1 = new Resourse("Золото", 9);
        var gold_2 = new Resourse("Золото", 5);
        var wood = new Resourse("Дерево", 3);

        var sim = gold_1 + gold_2;

        var PriceInfo = GetPrice("Золото");
        var final = new
        {
            ResourseName = sim.Name,
            TotalValue = sim.Quantity * PriceInfo.GoldPrice,
            Status = PriceInfo.IsRare ? "Легендарный" : "Обычный"
        };
        Console.WriteLine($"Общее золото: {sim.Quantity}");

        Console.WriteLine($"Цена за единицу: {PriceInfo.GoldPrice}, редкий: {PriceInfo.IsRare}");
    }

    static (int GoldPrice, bool IsRare) GetPrice(string Name)
    {
        return Name switch
        {
        "Дерево" => (5, false),
        "Золото" => (20, false),
        "Железо" => (100, false),
        _ => (1, false)
        };
    }
}
