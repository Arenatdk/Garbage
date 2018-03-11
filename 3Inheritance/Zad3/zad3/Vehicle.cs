using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Vehicle
    {
        public int Kord { get; set; }
        public int Cena { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(int Cena,int Year)
        {
            this.Cena = Cena;
            this.Year = Year;
        }
    }
}
