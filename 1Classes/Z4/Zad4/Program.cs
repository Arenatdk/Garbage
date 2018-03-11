using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point("nnm1",1,1);
            Point p2 = new Point("nnm2", 5, 1);
            Point p3 = new Point("nnm3", 5, 5);
            Point p4 = new Point("nnm4", 1, 5);

            Figure f = new Figure(p1, p2, p3, p4);
            //Figure f=new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4));
            Console.WriteLine("Тип {0}",f.Type);
            f.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
