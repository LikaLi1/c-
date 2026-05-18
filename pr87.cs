namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            string text = "Hello World";

            string fileText = File.ReadAllText(path);
            //сохранил в архиве этот созданный документ
            File.WriteAllText(path, text);
            File.WriteAllLines();
            File.WriteAllBytes();

            File.ReadAllText(path, text);
            File.ReadAllLines();
            File.ReadAllBytes();

            File.AppendAllText(path, text);
            File.AppendAllLines();
            File.AppendAllBytes();

            Console.WriteLine(fileText);

            .CteateText();
            .Append();
            .OpenText();



            string path2 = @"C:\";
            string path3 = null;
            try
            {
                Console.WriteLine(File.ReadAllText(path2));
                Console.WriteLine(path3.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return;
            }
            finally
            {
                Console.WriteLine("Всегда выполяется после работы try/catch игнорируя return");
            }



            FileInfo file = new FileInfo(@"text.txt");

            FileStream;
            StreamWriter;
            StreamReader;
            StreamContent;



            string text2 = "Hello World";
            FileInfo files = new FileInfo(@"text.txt");
            //StreamWriter? writer = null;
            //try
            //{
            //    writer = files.CreateText();
            //    writer.WriteLine(text2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    writer.Close();
            //}
            //вместо try/catch/finally используем using
            using (StreamWriter writer = file.CreateText())
            {
                writer.WriteLine(text2);
            }
            using (StreamReader reader = file.OpenText())
            {
                string? line;
                while((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }
        }
    }
}
