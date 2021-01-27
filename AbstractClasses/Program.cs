using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDatabase abstractDatabase1 = new MySqlDatabase();
            AbstractDatabase abstractDatabase2 = new OracleDatabase();

            abstractDatabase1.Add();
            abstractDatabase1.Add();

            abstractDatabase1.update();
            abstractDatabase2.update();

        }
    }
}
