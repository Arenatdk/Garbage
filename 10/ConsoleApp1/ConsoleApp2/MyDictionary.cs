using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] key;
        TValue[] value;
        int count;

        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];

        }

        public void Add(TKey k, TValue v)
        {
            // if (key.Length == count) return;
            key[count] = k;
            value[count] = v;
            count++;
        }

        public int Length { get { return key.Length; } }

        public string this[int index]
        {
            get
            {
                return key[index] + " " + value[index];
            }
        }


    }
}
