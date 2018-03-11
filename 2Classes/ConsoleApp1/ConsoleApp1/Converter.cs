using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Converter
    {
        double usd;
        double eur;
        double rub;

        public Converter(double usd,double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ToUSD(double hrn)
        {
            return hrn / this.usd;
        }

        public double FromUSD(double USD)
        {
            return USD * this.usd;
        }


        public double ToEUR(double hrn)
        {
            return hrn / this.eur;
        }

        public double FromEUR(double EUR)
        {
            return EUR * this.eur;
        }


        public double ToRUB(double hrn)
        {
            return hrn / this.rub;
        }

        public double FromRUB(double RUB)
        {
            return RUB * this.rub;
        }


    }
}
