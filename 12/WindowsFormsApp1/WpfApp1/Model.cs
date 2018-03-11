using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApp1
{
    public class Model
    {
        public string Plus(string s1 , string s2)//    +
        {
            int a = Convert.ToInt32(s1);
            int b = Convert.ToInt32(s2);
            return (a + b).ToString();
        }

        public string Minus(string s1, string s2)//   -
        {
            int a = Convert.ToInt32(s1);
            int b = Convert.ToInt32(s2);
            return (a - b).ToString();
        }

        public string Multiply(string s1, string s2)//  *
        {
            int a = Convert.ToInt32(s1);
            int b = Convert.ToInt32(s2);
            return (a * b).ToString();
        }

        public string Divide(string s1, string s2)//    /
        {
            
            int a = Convert.ToInt32(s1);
            double b = Convert.ToInt32(s2);
            if (b == 0) return "Деление на ноль";
            return ((double)a / b).ToString();
        }
    }
}