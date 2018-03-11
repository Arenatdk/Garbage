using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad0
{
    class Program
    {
        static void Main(string[] args)
        {
            MFU mfu = new MFU(ConsoleColor.DarkRed);
            mfu.Print("MFU");

            Printer pr = mfu;
            pr.color = ConsoleColor.Yellow;
            pr.Print("printer");


            mfu.color = ConsoleColor.Green;
            MFU upMFU = (MFU)pr;
            upMFU.Print("upcast");

            Console.ReadKey();
        }
    }
}
