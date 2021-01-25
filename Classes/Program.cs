using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Bursa";
            customer.Id = 1;
            customer.FirstName = "Ali";
            customer.LastName = "Can";

            Customer customer2 = new Customer //Customer sınıfı set bloğu çalışır.
            {
                Id = 2,
                City = "Bursa",
                FirstName = "Ayşe",
                LastName = "Can"
            };

            Console.WriteLine(customer2.FirstName); //Customer sınıfı get bloğu çalışır
        }
    }

    
    
}

