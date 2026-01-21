using System;

namespace ConsoleApp2
{
    class Warehouse
    {
        private string[] temp = new string[10];

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < temp.Length)
                {
                    return temp[index];
                }
                else
                {
                    return "Tovar ne naiden";
                }
            }
            set
            {
                if (index >= 0 && index < temp.Length)
                {
                    temp[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] == name)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Warehouse warehouse = new Warehouse();

                warehouse[0] = "Ноутбук";
                warehouse[1] = "Смартфон";
                warehouse[2] = "Планшет";

                Console.WriteLine($"Товар с артикулом 0: {warehouse[0]}");
                Console.WriteLine($"Товар с артикулом 1: {warehouse[1]}");
                Console.WriteLine($"Товар с артикулом 2: {warehouse[2]}");
            }
        }
    }
}
