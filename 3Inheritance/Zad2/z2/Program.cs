using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom cr = new ClassRoom();
            cr.Study();
            Console.WriteLine("--------------------");
            cr.Read();
            Console.ReadKey();
        }
    }
}
