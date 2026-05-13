using System;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp5
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string[] deliveryLogs = {
            "Иван:Москва:450",
            "Ольга:Санкт-Петербург:500",
            "Иван:Москва:300",
            "Алексей:Краснодар:400",
            "Ольга:Москва:600",
            "Иван:Краснодар:350",
            "Алексей:Краснодар:200"
            };

            List<string> cities = new List<string>();
            Dictionary<string, List<int>> curiers = new Dictionary<string, List<int>>();
            foreach (string item in deliveryLogs)
            {
                string[] result = item.Split(':');

                string city = result[1];
                string name = result[0];
                int amout = int.Parse(result[2]);
                if (!cities.Contains(city))
                {
                    cities.Add(city);
                }
            }
        }
    }
}
