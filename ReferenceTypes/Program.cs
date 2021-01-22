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
            Console.WriteLine("sayı1: "+sayi1);

            //referans tipler-heap
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(("Sayılar1[0]: " + sayilar1[0]));

            foreach(int sayi in sayilar1)
            {
                Console.WriteLine("sayilar1: "+sayi);
            }
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
}
