namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Student\Logs";
            DirectoryInfo folder = new DirectoryInfo(path);
            if (!folder.Exists)
            {
                folder.Create();
            }
            DirectoryInfo parentFolder = folder.Parent;
            DirectoryInfo subDir = folder.CreateSubdirectory(parentFolder.Name);
            if (subDir.Exists)
            {
                Console.WriteLine(subDir.CreationTime);
            }


            string wifi = @"C:\Users\Student\Downloads\login";
            DirectoryInfo wifiFolder = new DirectoryInfo(wifi);
            Console.WriteLine(wifiFolder.FullName);
            foreach (FileInfo file in wifiFolder.GetFiles())
            {
                double sizeInKb = file.Length / 1024.0;
                if (file.Extension == ".txt" || file.Extension == ".pdf")
                    Console.WriteLine($"{file.FullName} {sizeInKb} {file.CreationTime}");
            }
        }
    }
}
