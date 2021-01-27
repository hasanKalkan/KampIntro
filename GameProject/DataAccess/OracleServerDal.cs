using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccess
{
    public class OracleServerDal : IDatabaseDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated.");
        }
    }
}
