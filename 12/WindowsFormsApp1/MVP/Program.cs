using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class Program
    {
        public delegate void MyDeligat(string s);

        public static event MyDeligat TextAdd;

        static void Main(string[] args)
        {
            new Presenter();
            string str = "";
            while (true)
            {
                str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    TextAdd.Invoke(str);
                }
            }
        }
    }
}
