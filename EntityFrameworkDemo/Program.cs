using System;
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

            //GetAll();
            GetProductsByCategoryId(1);

        }

        private static void GetAll()
        {
            NortwindContext nortwindContext = new NortwindContext();
            foreach (var product in nortwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategoryId(int categoryId)
        {
            NortwindContext nortwindContext = new NortwindContext();
            var result = nortwindContext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
