namespace ConsoleApp12
{
    internal class Program
    {
        delegate Predicate<T>;
        class User
        {
            public string name { get; set; }
            public int age { get; set; }
            public string status { get; set; }
            void FlterUsers(List<User> users, Predicate<User> condition);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
