//=================================================================================================
// Logger.dll   версия 0.1
// создан: 20.03.24
// последнее изменение: 12.04.24
//=================================================================================================
using System;
using System.IO;

namespace Log
{
    /// <summary>
    /// class Logger простенький логгер для своих нужд.
    /// </summary>
    public static class Logger
    {
        public delegate void LoggerHandler(string message);
        private static LoggerHandler handler;
        public static void RegisterHandler(LoggerHandler del) => handler = del;
        public static void System(string text) => Message("System", text);
        public static void Info(string text) => Message("Info", text);
        public static void Error(string text) => Message("Error", text);
        public static void Debug(string text) => Message("Debag", text);


        // Метод для логирования.
        //private static void Message(string text)
        //{
        //    string path = $"{Environment.CurrentDirectory}\\{DateTime.Now.ToShortDateString().Replace('.', '-')}.log";
        //    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path, true))
        //    {
        //        writer.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + ": " + text);
        //        writer.Flush();
        //    }
        //}

        private static void Message(string level, string text)
        {
            string fileName = $"{DateTime.Now:dd-MM-yyyy}.log";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            string message = $"{DateTime.Now:G}: [{level}]: {text}";

            try
            {
                File.AppendAllText(path, $"{message}\n");
            }
            catch (Exception ex)
            {
                // Обработка исключения (например, запись ошибки в другой файл лога
                // или вывод в консоль, если это критично).
                handler?.Invoke($"Failed to write to log file: {ex.Message}");
            }
        }
    }
}
