using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Car
    {
        public Car(string Name, DateTime Date)
        {
            this.Name = Name;
            this.Date = Date;

           
        }

        public override string ToString()
        {
            return Name + " " + Date.ToString("dd/MM/yyyy");
        }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }


    class BMW : Car
    {
        public string Model { get; set; }
        public BMW(string Model, DateTime Date) : base("BMW", Date)
        {
            this.Model = Model;

        }

        public override string ToString()
        {
            return Name + " " + Model + " " + Date.ToString("dd/MM/yyyy");
        }
    }


    class CarCollection< T> : MyList<T> where T:Car 
    {
        
    }
}
