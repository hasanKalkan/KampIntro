using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int refDeger = 5;//başlangıç değeri atanması zorunludur.
            int outDeger;//başlangıç değeri atanması zorunlu değildir.

            ChangeMethod(out outDeger, ref refDeger);

            Console.WriteLine("ChangeMethod'dan sonra refDeger : " + refDeger); // 7
            Console.WriteLine("ChangeMethod'dan sonra outDeger: " + outDeger); // 8
        }

        static void ChangeMethod(out int i, ref int j)
        {
            i = 8; // i argümanına bir değer atamak zorunludur
            j = j + 2; // j için böyle bir zorunluluk yoktur
        }
    }
}
