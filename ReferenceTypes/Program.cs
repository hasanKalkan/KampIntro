using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,boolean : değer tipleridir. stack
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayı1: "+sayi1); //20

            //referans tipler-heap
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;  //sayilar1[0] da 1000 oldu.
            Console.WriteLine(("Sayılar1[0]: " + sayilar1[0])); //1000

            /*  foreach(int sayi in sayilar1)
              {
                  Console.WriteLine("sayilar1: "+sayi);
              }*/

          /*  Person person1 = new Person();
            Person person2 = new Person();

            person1.FirsName = "Ali";

            person2 = person1;
            person1.FirsName = "Ahmet"; // person2.FirstName de Ahmet oldu.
           

            Console.WriteLine("person2.FirsName: "+person2.FirsName); */ //Ahmet
            

            Customer customer = new Customer();
            customer.FirsName = "Can";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirsName = "Ayşe";
            
            //customer = employee; //bu satır çalışmaz. farklı türler
                        
            Person person3 = customer;
            customer.FirsName = "Canan";

            Console.WriteLine(((Customer)person3).CreditCardNumber); //boxing-kutulama

            Console.WriteLine("person3.FirstName: "+person3.FirsName); //Can

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(employee);



        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person //Inheritance:Kaltım-Miras
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person //Person özellikleri employee miras bırakılır
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirsName+" eklendi.");
        }
    }
}
