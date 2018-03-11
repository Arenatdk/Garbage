using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Address
        {
            public int Index { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string House { get; set; }
            public string Apartment { get; set; }


        }
        static void Main(string[] args)
        {
            Address ad = new Address();
            ad.Index = 14;
            ad.City = "Ods";
            ad.Street = "strt";
            ad.House = "hse";
            ad.Apartment = "appp";
            Console.WriteLine(ad.Index);
            Console.ReadKey();
        }
    }
}
