using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Title
    {
        private string title;
        public Title(string title)
        {
            this.title = title;
        }
        
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(title);
        }
    }
}
