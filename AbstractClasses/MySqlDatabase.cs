using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public class MySqlDatabase : AbstractDatabase
    {
        public override void update()
        {
            Console.WriteLine("MySql Güncellendi...");
        }

        public override void get()
        {
            Console.WriteLine("MySql Verileri Aldı...");
        }
    }
}
