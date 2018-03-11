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
            MyMatrix mm = new MyMatrix(10, 5);
            mm.Show();
            Console.WriteLine(new string('-',10));
            mm.ChangeSize(3, 8);
            mm.Show();
            Console.ReadKey();
        }
    }
}
