using System.IO;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

string path = @"text.txt";

using (FileStream file = new FileStream(path, FileMode.Create))
{
    string text = "Hello Word";
    byte[] buffer = Encoding.UTF8.GetBytes(text);
    file.Write(buffer, 0, 4);
    file.Write(buffer, 0, text.Length);
}

using (FileStream file = new FileStream(path, FileMode.Open))
{
    Console.WriteLine(file.Length);
    Console.WriteLine(file.Name);
    Console.WriteLine((char)file.ReadByte());
    file.Seek(2, SeekOrigin.Begin);
    Console.WriteLine(file.Position);
    byte[] buffer = new byte[file.Length];
    file.Read(buffer, 0, buffer.Length);
    Console.WriteLine(Encoding.UTF8.GetString(buffer));
}


using (StreamWriter file = new StreamWriter(path, true))
{
    file.WriteLine("Hello Word");
}

using (StreamReader file = new StreamReader(path))
{
    Console.WriteLine(file.Peek());
    Console.WriteLine(file.Read());
    Console.WriteLine(file.ReadLine());
    Console.WriteLine(file.ReadToEnd());
}
