using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Model
    {
        int i;
        public string Tick()
        {
            i++;
            return i.ToString(); 
        }

        public void Reset()
        {
            i = 0;
        }


    }
}