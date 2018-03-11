using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = Convert.ToDouble( Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------");
            Rectangle r = new Rectangle(a, b);
            Console.WriteLine("P = "+r.Perimeter);
            Console.WriteLine("A = "+r.Area);
            Console.ReadKey();
        }
    }
}
