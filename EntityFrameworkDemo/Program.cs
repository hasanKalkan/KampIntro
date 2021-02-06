using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET: Veri tabanına bağlanmamızı ve kontrol edip sorgu yazmamımızı sağlayan bir kütüphanedir.
            //Bu kütüphane vasıtasıyla seçme, güncelleme, silme işlemleri yapabiliriz.
            //Günümüzde ADO.NET biraz yorucu olmaktadır.

            //ORM :Entity Framework bir ORM: Object Relational Mapping
            //Nhibernate
            //Dapper

            // GetAll();

            Car newCar = new Car()
            {
                Id = 5,
                BrandId = 3,
                ColorId = 2,
                ModelYear = 1978,
                DailyPrice = 140000,
                Description = "1978 Pontiac Firebird Trans Am"
            };
            GetAll();

            Add(newCar);
            GetAll();

            Delete(newCar);
            GetAll();

            Add(newCar);
            GetAll();

            newCar.Id = 5;
            Update(newCar);
            GetAll();

            GetCarsById(5);

            Delete(newCar);
            GetAll();
        }

        private static void Add(Car newCar)
        {
            ReCapProject context = new ReCapProject();

            var addedEntity = context.Entry(newCar);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
            Console.WriteLine("\n"+newCar.Description + " eklendi.");
        }


        private static void Delete(Car newCar)        {
            ReCapProject context = new ReCapProject();
            var deletedEntity = context.Entry(newCar);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
            Console.WriteLine("\n" + newCar.Description + " silindi.");
        }
        private static void Update(Car newCar)
        {
            ReCapProject context = new ReCapProject();            
            var updatedEntity = context.Entry(newCar);
            newCar.Description = "Ford Mustang GT";
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
            Console.WriteLine("\n" + newCar.Description + " değiştirildi.");
            Console.WriteLine("{0} {1} {2}", newCar.Id, newCar.Description, newCar.DailyPrice);
            

        }

        private static void GetAll()
        {
            Console.WriteLine("\n"+"Listelenen Araçlar");
            ReCapProject context = new ReCapProject();
            foreach (var car in context.Cars)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetCarsById(int Id)
        {
            ReCapProject context = new ReCapProject();
            var result = context.Cars.Where(c => c.Id == Id);
            foreach (var car in result)
            {
                Console.WriteLine("\n"+car.Id+" numaralı araç: "+car.Description+" listelendi.");
            }
        }

    }
}
