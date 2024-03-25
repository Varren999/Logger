//=================================================================================================
// Logger.dll   версия 0.1
// создан: 20.03.24
// последнее изменение: 25.03.24
//=================================================================================================
using System;

namespace Log
{
    /// <summary>
    /// class Logger простенький логгер для своих нужд.
    /// </summary>
    public static class Logger
    {
        public static void System(string text)
        {
            Message("System: " + text);
        }
        public static void Info(string text)
        {
            Message("Info: " + text);
        }
        public static void Error(string text)
        {
            Message("Error: " + text);
        }
        public static void Debag(string text)
        {
            Message("Debag: " + text);
        }


        // Метод для логирования.
        private static void Message(string text)
        {
            string path = $"{Environment.CurrentDirectory}\\{DateTime.Now.ToShortDateString().Replace('.', '-')}.log";
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path, true))
            {
                writer.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + ": " + text);
                writer.Flush();
            }
        }
    }
}
