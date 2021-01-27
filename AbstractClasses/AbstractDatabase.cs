using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public abstract class AbstractDatabase
    {
        public void Add()
        {
            Console.WriteLine("Eklendi...");
        }
        
        public void Delete()
        {
            Console.WriteLine("Silindi...");
        }

        public abstract void update();
        public  abstract void get();

    }
}
