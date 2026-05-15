namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Folder";
            DirectoryInfo folder = new DirectoryInfo(path);
            if (!folder.Exists)
            {
                folder.Create();
            }
            DirectoryInfo parentFolder = folder.Parent;
            foreach(var folders in parentFolder.GetDirectories())
            {
                Console.WriteLine(folders);
            }
            foreach (var files in parentFolder.GetFiles())
            {
                if (files.Extension = ".ico")
                Console.WriteLine($"{files.FullName} {files.CreationTime}");
                if (files.Attributes == FileAttributes.Hidden)
                    Console.WriteLine($"{files.FullName} {files.CreationTime}");
            }
            Console.WriteLine(folder.Exists);
            Console.WriteLine(folder.Name);
            Console.WriteLine(folder.FullName);
            Console.WriteLine(folder.Root);
            Console.WriteLine(folder.Extension);
            Console.WriteLine(folder.LinkTarget);
            Console.WriteLine(folder.CreationTime);
            Console.WriteLine(folder.LastAccessTime);
            Console.WriteLine(folder.LastWriteTime);
            Console.WriteLine(folder.Attributes);
        }
    }
}
