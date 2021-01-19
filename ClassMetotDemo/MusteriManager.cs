using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " isimli müşteri başarıyla eklendi.");
        }

        public void Sil(string musteriAdi, string musteriSoyadi)
        {
            Console.WriteLine(musteriAdi + " isimli müşteri başarıyla silindi.");
        }
    }

}
