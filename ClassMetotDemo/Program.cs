using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Can";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Veli";
            musteri2.Soyad = "Kaya";

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach(var musteri in musteriler)
            {
                Console.Write("Müşteri adı: " + musteri.Ad);
                Console.Write(", soyadı: " + musteri.Soyad+"\n");
                musteriManager.Ekle(musteri);
            }

            Console.WriteLine("\n----------------Metotlar----------------");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("\n");
            musteriManager.Sil("Kamil", "Can");
            musteriManager.Sil("Ayşe", "Nur");

            Console.WriteLine("\n");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
        }
    }
}
