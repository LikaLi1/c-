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
