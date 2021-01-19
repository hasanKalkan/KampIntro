using System;
using System.Linq;

namespace OverloadVeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(topla(2, 5));
            Console.WriteLine(topla(2, 5,9));
            Console.WriteLine(toplaParams(2, 5,9,4,5,6));
        }

        static int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int topla(int sayi1, int sayi2,int sayi3)
        {
            return sayi1 + sayi2 + sayi3 ;
        }

        static int toplaParams(params int[] sayilar)
        {
            return sayilar.Sum();
        }
    }
}
