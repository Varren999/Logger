using Log;
using System;

namespace TestLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.RegisterHandler(PrintMessage);
            Logger.System("Запуск программы");
            Logger.Info("Программа работает");
            Logger.Error("Ошибка программы");
            Logger.Debug("Тест дебага");
            Logger.System("Завершение программы");
        }

        static void PrintMessage(string message) => Console.WriteLine(message);
    }
}
