using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Bilgisayar" },
                new Category { CategoryId = 2, CategoryName = "Telefon" },
            };

            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 5000, UnitsInStock=5},
                new Product { ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 8000, UnitsInStock=3},
                new Product { ProductId = 3, CategoryId = 1, ProductName = "Hp Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 6000, UnitsInStock=2},
                new Product { ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 5000, UnitsInStock=15},
                new Product { ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 10000, UnitsInStock=0},
            };
            // Test(products);

            // Metotlu(products);

            // AnyTest(products);

            // FindTest(products);

            //FindAllTest(products);

            //AscDescTest(products);

            // ClassicLinqTest(products);

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId //equals yerine == kullanamayız
                         where p.UnitPrice>5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result)
            {
                Console.WriteLine(productDto.ProductName + " " + productDto.CategoryName);
            }

        }

        private static void Metotlu(List<Product> products)
        {
            Console.WriteLine("\nMetotlu--------------------");
            var result1 = GetProductsLinq(products);
            foreach (var product in result1)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         // select p.p;
                         // select p.ProductName;
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var product in result)
            {
                // Console.WriteLine(product.ProductName+" "+product.UnitPrice);
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            //Single line query
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenByDescending(p => p.ProductName);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName + " " + product.UnitPrice);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            //lambda
            var result = products.Find(p => p.ProductId == 3); //Product id si 3 olan kayıtları bulur.
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");//result true;
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik------------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName); //acer laptop
                }
            }

            Console.WriteLine("\nLinq------------------");
            var result = products.Where(product => product.UnitPrice > 5000 && product.UnitsInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName); //Aynı şeyi yazdırır.
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product); 
                    Console.WriteLine(filteredProducts);
                }
               
            }
            return filteredProducts; 
        }

        static List<Product> GetProductsLinq(List<Product> products) //kodların linq ile yazımı
        {
            List<Product> filteredProducts = new List<Product>();

            return products.Where(product => product.UnitPrice > 5000).ToList() ;
        }

    }

    class ProductDto //Dto:Data Transformassion Object
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
