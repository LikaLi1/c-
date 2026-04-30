LinkedList<int> a;
LinkedListNode<int> b = new LinkedListNode<int>(5);

LinkedList<int> c = new LinkedList<int> ();

LinkedList<int> d = new LinkedList<int> (new int[] {1,2,3});
Console.WriteLine(d.Count);
Console.WriteLine(d.First);
Console.WriteLine(d.Last);
Console.WriteLine(d.First?.Value);
Console.WriteLine(d.Last?.Value);
Console.WriteLine(d.First.Next);
Console.WriteLine(d.Last.Next);

var v = d.First;
v = v.Next;

while (v != null)
{
    Console.WriteLine(v.Value);
    v = v.Next;
} 

v = d.Last;

while (v != null)
{
    Console.WriteLine(v.Value);
    v = v.Previous;
}

foreach (int i in d)
{ 
    Console.WriteLine(i); 
}

d.ToList().ForEach (x => Console.WriteLine(x));

var currentNode = d.Find(2);
d.AddAfter(currentNode, 123);

Queue<int> e = new Queue<int> ();


List<string> sites = new List<string>()
{
    "google.com",
    "microsoft.com",
    "github.com"
};
LinkedList<string> list = new LinkedList<string> (sites);

//list.AddLast("google.com");
//list.AddLast("microsoft.com");
//list.AddLast("github.com");

var currentList = list.Find("microsoft.com");

if (currentList != null)
list.AddAfter(currentList, "stackoverflow.com");

list.AddFirst("yandex.ru");

var lists = list.Last;
while (lists != null)
{
    Console.WriteLine (lists.Value);
    lists = lists.Previous;
}
