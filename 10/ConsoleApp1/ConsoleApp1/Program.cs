using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class PlusMyList
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] tmp = new T[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                tmp[i] = list[i];
            }
            return tmp;
        }

    }

    class Program
    {



        static void Main(string[] args)
        {
            IMyList<int> ml = new MyList<int>(0);
            ml.Add(1);
            ml.Add(2);
            ml.Add(3);
            ml.Add(4);
            ml.Add(5);
            //ml.Clear();
            ml.Add(6);
            ml.Add(7);
            ml.Add(8);
            ml.Add(9);
            Console.WriteLine("-----------------");
            Console.WriteLine(ml[4]);
            Console.WriteLine(ml[5]);
            Console.WriteLine("-----------------");
            for (int i = 0; i < ml.Length; i++)
            {
                //if (i == 4 || i==5) 
                Console.WriteLine(ml[i]); 
            }
            Console.WriteLine("-----------------");

            MyList<int> m = (MyList<int>)ml;


           
            foreach (var item in m.GetArray())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
