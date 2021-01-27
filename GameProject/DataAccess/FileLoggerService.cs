using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccess
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
}
