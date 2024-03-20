using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Logger
{
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

        // Метод для логирования.
        private static void Message(string text)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + ": " + text);
                writer.Flush();
            }
        }
    }
}
