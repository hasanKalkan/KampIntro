using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {


        /// <summary>
        /// abstract sınıflar da inheritance kullanılır. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName="Ali" 
                },
                new Student
                {
                    FirstName="Ayşe"
                },
                new Person
                {
                    FirstName="Ahmet"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadKey();

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNanme { get; set; }

    }

    class Person2
    {

    }

    class Customer : Person // ,Person2 yazamayız. interface gibi iki özellik yazamayız.
    {
        public string City { get; set; }
    }

    class Student : Person //yanına istediğimiz kadar interface yazabiliriz. ,IPerson, IPerson2 gibi. önce inheritance sonra interface yazılır. 
    {
        public string Department { get; set; }
    }

   //class ların tek başına bir anlamı vardır. ama interface lerin tek başına bir anlamı yoktur.
   // ikisi de inheritance gibi miraslama yapabiliyor. 
   // aslında interface ler de bir implemantasyondur.
}
