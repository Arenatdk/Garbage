using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        interface Itest
        {
            void t();
        }

        class CLTest : Itest
        {
            public void  t()
            {
                Console.WriteLine("test");
            }


        }
        static void Main(string[] args)
        {
            CLTest clt = new CLTest();
            Console.WriteLine(clt.GetHashCode());

            CLTest clt1 = new CLTest();
            Console.WriteLine(clt1.GetHashCode());

            Console.WriteLine((clt as Itest).GetHashCode());
            Console.ReadKey(); 
        }
    }
}
