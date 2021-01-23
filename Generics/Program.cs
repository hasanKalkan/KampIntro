using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T> // T parametre ismi, herhangi bir isim de olabilir.
    {
        T[] _array;  //_array ismini değiştirebiliriz
        T[] _tempArray;

        public MyList() //kurucu sınıf
        {
            _array = new T[0]; // yeni bir MyList sınıfı oluşturulduğunda dizi değeri sıfır olarak belirlenir.
        }
            
         public void Add(T item)
        {             
            _tempArray = _array; //dizi geçici olarak _tempArray dizisine aktarılır. aktarma yapmazsak _array dizisinin içi boş kalır.
            _array = new T[_array.Length + 1]; //diziye eleman eklenince dizinin değeri bir artar.
            for (int i = 0; i < _tempArray.Length; i++)
            {   
                 _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;//eklenen eleman dizinin sonuna koyulur. dizinin son indeksi eleman sayısının bir eksiğidir.

        }
        public int Count
        {
          get { return _array.Length; }
        }
    }
}
