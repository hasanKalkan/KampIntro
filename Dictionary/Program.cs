using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> CityAndCode = new MyDictionary<string, int>();

            CityAndCode.Add("Bursa", 16);
            CityAndCode.Add("İstanbul", 34);
            CityAndCode.Add("Ankara", 06);
            CityAndCode.Add("İzmir", 35);

                       
            foreach (var key in CityAndCode.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in CityAndCode.Values)
            {
                Console.WriteLine(value);
            }

        }
    }
}
