using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        { 
           
            Store st = new Store();
            Console.WriteLine(st[1]);
            Console.WriteLine(new string('-',50));
            Console.WriteLine(st.Length);
            Console.ReadKey();
        }
    }
}
