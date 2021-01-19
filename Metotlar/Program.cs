using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Ceviz";
            urun1.Fiyati = 30;
            urun1.Aciklama = "Bodur Ceviz";

            Urun urun2 = new Urun();
            urun2.Adi = "Kiraz";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Napolyon Kiraz";

            SepetManager sepetManager = new SepetManager();
            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach(var urun in urunler)
            {
                Console.Write("Ürün adı: "+urun.Adi);
                Console.Write(", Fiyatı: "+urun.Fiyati);
                Console.Write(", Açıklama: "+urun.Aciklama+"\n");
                sepetManager.Ekle(urun);
            }

            Console.WriteLine("----------------Metotlar-------------------");
            //encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            
            
            sepetManager.Ekle2(urun1.Adi,urun1.Aciklama,urun1.Fiyati);
            sepetManager.Ekle2(urun2.Adi, urun2.Aciklama, urun2.Fiyati);

        }
    }
}
