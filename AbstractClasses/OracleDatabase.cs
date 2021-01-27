using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public class OracleDatabase : AbstractDatabase
    {
        public override void update()
        {
            Console.WriteLine("Oracle Güncellendi...");
        }

        public override void get()
        {
            Console.WriteLine("Oracle Verileri Aldı...");
        }
    }
}
