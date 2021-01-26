using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach(var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
          {
                new Manager(),
                new Worker()
          };

            foreach (var eat in eats)
            {
                eat.Eat();
            }



        }

        interface IWorker
        {
            void Work();           
        }
        /*SOLID yazılım prensipleri; geliştirilen yazılımın esnek, yeniden kullanılabilir, 
         * sürdürülebilir ve anlaşılır olmasını sağlayan, kod tekrarını önleyen 
         * ve Robert C. Martin tarafından öne sürülen prensipler bütünüdür.*/

        //s: Single-responsibility principle: Bir sınıf (nesne) yalnızca bir amaç uğruna değiştirilebilir
        //o: Open-closed principle: Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir.
        //l: Liskov substitution principle: Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, türedikleri(üst) sınıfların yerine kullanabilmeliyiz.
        //i:  Interface segregation principle: Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız.
        //d: Dependency Inversion Principle: Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.

        interface IEat
        {
            void Eat();
        }

        interface ISalary
        {
            void GetSalary();
        }



        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
}
