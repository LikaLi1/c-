using System;

namespace Proga
{
    interface Logger
    {
        void Log(string message);
    }

    class ConsoleLogger : Logger

    {
        public void Log(string message)
        {
            Console.WriteLine($"Запись в консоли: {message}");
        }
    }

    class FileLogger : Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Запись в файл: {message}");
        }
    }

    interface IMessage
    {
        public void Send();
    }

    interface IExtendedMessage : IMessage
    {
        public void AddAttachment(string fileName);
    }

    class EmailService : IExtendedMessage
    {
        public void Send()
        {
            Console.WriteLine("Сообщение отправлено");
        }
        public void AddAttachment(string fileName)
        {
            Console.WriteLine($"Файл {fileName} отправлен");
        }
    }

public class Program
    {
        public static void Main()
        {
            Logger logger = new ConsoleLogger();
            Logger fileLogger = new FileLogger();

            logger.Log("Начало");
            fileLogger.Log("Закрыто");

            IExtendedMessage email = new EmailService();

            email.Send();
            email.AddAttachment("PNG");
        }
    }
}
