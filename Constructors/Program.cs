using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
        }
    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Constructor çalıştırıldı.");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
