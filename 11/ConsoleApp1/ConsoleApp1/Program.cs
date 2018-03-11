using System;
using System.Collections;
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
            ArrayList ar1 = new ArrayList();

            ar1.Add(1);
            ar1.Add(2);
            ar1.Add(1);
            ar1.Add(3);
            ar1.Add(1);
            ar1.Add(1);

            for (int i = 0; i < ar1.Count; i++)
            {
                Console.WriteLine(ar1[i]);
            }

            ArrayList ar2 = new ArrayList();

            ar2.Add("asd");
            ar2.Add("asd");
            ar2.Add("asd");
            ar2.Add("asd");
            ar2.Add("asd");
            ar2.Add("asd");

            Console.WriteLine("Calss");
            for (int i = 0; i < ar2.Count; i++)
            {
                Console.WriteLine(ar2[i]);
            }
            Console.ReadKey();
        }
    }
}
