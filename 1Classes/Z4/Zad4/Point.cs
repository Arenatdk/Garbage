using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Point
    {
        int x;
        int y;
        string name;

        public int X
        { get
            {
                return x;
            }
        }
        public int Y
        { get
            {
                return y;
            }
        }

        public string Name
        { get
            {
                return name;
            }
         }
        public Point(string name,int x , int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
