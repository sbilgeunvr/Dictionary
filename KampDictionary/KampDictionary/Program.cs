using System;
using System.Collections.Generic;

namespace KampDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> City = new MyDictionary<int, string>(); // K ve V int ve string veri tipinde
            City.Add(34, "Istanbul");
            City.Add(06, "Ankara");
            City.Add(35, "Izmir");
            City.Add(16, "Bursa");
            City.Add(01, "Adana");

            City.Liste(); 


        }

    }
}
