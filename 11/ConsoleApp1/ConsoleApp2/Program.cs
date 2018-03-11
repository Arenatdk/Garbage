using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            IMyList<Car> CC = new CarCollection<Car>();

            CC.Add(new Car("Jiguli", DateTime.Now));
            CC.Add(new BMW("M5", DateTime.Now));


            for (int i = 0; i < CC.Length; i++)
            {
                Console.WriteLine(CC[i]+"          " +CC[i].GetType());
                
            }
            Console.ReadKey();
        }
    }
}
