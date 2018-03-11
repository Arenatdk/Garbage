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
            Redactor rd = new Redactor("file.xml");

            rd.Create();
            rd.Open();
            rd.Change();
            rd.Save();

            Console.ReadKey();
        }
    }
}
