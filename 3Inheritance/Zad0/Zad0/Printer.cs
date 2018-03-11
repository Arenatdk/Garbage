using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad0
{
    class Printer
    {
        public ConsoleColor color;

        public Printer(ConsoleColor color)
        {
            this.color = color;
        }
        

        public void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Принтер: {0}", value);
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }
    }
}
