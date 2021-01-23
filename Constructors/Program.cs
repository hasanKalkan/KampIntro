using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Ali", LastName = "Can", City = "Bursa" };
            Customer customer2 = new Customer(2, "Ayşe", "Can", "Bursa");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ahmet";
            customer3.LastName = "Can";
            customer3.City = "İstanbul";
            Console.WriteLine(customer1.FirstName);
        }
    }

    class Customer
    {
        public Customer() //Constructor-yapıcı blok
        {
            Console.WriteLine("Constructor çalıştırıldı.");
        }

        public Customer(int id,string firstName,string lastName,string city) //Constructor-yapıcı blok - overloading yapıldı.
        {
            Console.WriteLine("Constructor çalıştırıldı.");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
