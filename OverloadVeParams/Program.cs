using System;
using System.Linq;

namespace OverloadVeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(topla(2, 5));
            Console.WriteLine(topla(2, 5,9)); //overload
            Console.WriteLine(toplaParams(2, 5,9,4,5,6)); //params
        }

        static int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int topla(int sayi1, int sayi2,int sayi3) //Overload
        {
            return sayi1 + sayi2 + sayi3 ;
        }

        static int toplaParams(params int[] sayilar) //params
        {
            return sayilar.Sum();
        }
    }
}
