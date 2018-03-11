using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] { 1,2,3};
            foreach(int m in mas)
            {
                Console.Write(m+" ");
            }
            Console.WriteLine("\nMax: " + mas.Max());
            Console.WriteLine("Min: " + mas.Min());
            Console.WriteLine("Sum: " + mas.Sum());
            Console.WriteLine("avg: " + mas.Average());
            Console.ReadKey();
        }
    }
}
