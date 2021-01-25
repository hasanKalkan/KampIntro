using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Ali", LastName = "Can", Address = "Bursa" });

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Ayşe",
                LastName = "Can",
                Address = "Bursa"
            };
            manager.Add(customer2);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Veli",
                LastName = "Can",
                Departmant = "Bilişim"
            };
            manager.Add(student);

            Console.ReadKey();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
       public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person) // interface tanımlayarak hem customer hem student gönderebiliriz.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
