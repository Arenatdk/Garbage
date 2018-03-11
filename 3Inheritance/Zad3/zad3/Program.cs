using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane c = new Plane(12,2018,12222,33336);

            Console.WriteLine("god= {0}      \ncena= {1}    \nCountPass= {2}",c.Year, c.Cena,c.CountPas);
            Console.ReadKey();
        }

    }
}
