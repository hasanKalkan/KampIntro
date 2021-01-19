using System;

namespace RefAndOut
{
   
    class Program
    {

        static void Main()
        {

            int sayi1 = 3; //ref olduğu için değer atamamız gerekiyor.
            Console.WriteLine("Başlangıç değeri: {0}", sayi1); //Başlangıç değeri: 3

            Kare(sayi1); //ref ve out olmadan metot kullandık.
            Console.WriteLine("Kare() metodu sonrası: {0}", sayi1); //Kare() metodu sonrası: 3

            RefKare(ref sayi1); //RefKare metodunu çağırarak sayının değerini değiştirdik.
            Console.WriteLine("RefKare() metodu sonrası: {0}", sayi1); //RefKare() metodu sonrası: 9

            RefKare(ref sayi1); //RefKare metodunu çağırarak sayının değerini yine değiştirdik.
            Console.WriteLine("2.RefKare() metodu sonrası: {0}", sayi1); //2.RefKare() metodu sonrası: 81

            int sayi2;  //OutKare için sayi2 tanımladık ama değer atamadık..
            OutKare(out sayi2); //OutKare metodunu çağırarak sayının değerini değiştirdik.
            Console.WriteLine("OutKare() sonrası: " + sayi2); //OutKare() metodu sonrası: 25

            OutKare(out sayi2);
            Console.WriteLine("2.OutKare() sonrası: " + sayi2); //2.OutKare() metodu sonrası: 25 değişmedi.

        }

        static void Kare(int sayi1)
        {
            sayi1 = sayi1 * sayi1;
        }

        static void RefKare(ref int sayi1)
        {
            sayi1 = sayi1 * sayi1;
        }

        static void OutKare(out int sayi2)
        {
            sayi2=5;
            sayi2 = sayi2 * sayi2;
        }
    }
}