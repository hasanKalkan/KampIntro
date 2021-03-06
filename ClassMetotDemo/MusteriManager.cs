﻿using System;
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

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " isimli müşteri başarıyla silindi.");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler başarıyla listelendi.");
            foreach (Musteri musteri in musteriler) {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
        }
    }
}

