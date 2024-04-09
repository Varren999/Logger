using Log;

namespace TestLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.System("Запуск программы");
            Logger.Info("Программа работает");
            Logger.Error("Ошибка программы");
            Logger.Debug("Тест дебага");
            Logger.System("Завершение программы");
        }
    }
}
