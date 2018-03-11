using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Plane:Vehicle
    {
        public Plane(int cena,int year,int height,int count):base(cena,year)
        {
            this.Height = height;
            this.CountPas = count;
        }
        public int Height { get; set; }
        public int CountPas { get; set; }
    }
}
