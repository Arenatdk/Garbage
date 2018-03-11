using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyDictionary<string, string> MD = new MyDictionary<string, string>(3);
            MD.Add("0", "nole");
            MD.Add("1","odin");
            MD.Add("2", "dva");

            //MD.Add(4, "tri");
            Console.WriteLine("Длина: "+MD.Length);
            Console.WriteLine(MD[0]);
            Console.WriteLine(MD[1]);
            Console.WriteLine(MD[2]);
            Console.ReadKey();
        }
    }
}
