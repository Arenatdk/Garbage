using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter cv = new Converter(28.93, 35.57, 0.51);
            Console.WriteLine(cv.ToUSD(28.93));
            Console.WriteLine(cv.ToRUB(0.51));
            Console.WriteLine(cv.ToEUR(35.57));
            Console.ReadKey();
        }
    }
}
