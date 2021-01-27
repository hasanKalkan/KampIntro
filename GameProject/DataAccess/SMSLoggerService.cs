using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccess
{
    class SMSLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS sent...");
        }
    }
}
