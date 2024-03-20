using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.System("Запуск программы");
            Logger.Info("Программа работает");
            Logger.Error("Ошибка программы");
            Logger.System("Завершение программы");
        }
    }
}
