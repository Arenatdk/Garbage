using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    class Figure
    {
        Point[] p ;
        string type;
        public string Type { get { return type; } }

        double LengthSide(Point A, Point B)
        {   double a = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return a;
        }

        public void PerimeterCalculator()
        {
            double sum = 0;
           
            for (int i = 0; i < p.Length-1; i++)
            {
                sum += LengthSide(p[i], p[i+1]);               
            }
            sum += LengthSide(p[p.Length - 1], p[0]);
            Console.WriteLine("Периметр = {0}", sum);
        }

        public Figure(Point p1, Point p2, Point p3)
        {
            p = new Point[3];
            this.p[0] = p1;
            this.p[1] = p2;
            this.p[2] = p3;
            type = "3 ugla ";
        }


        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            p = new Point[4];
            this.p[0] = p1;
            this.p[1] = p2;
            this.p[2] = p3;
            this.p[3] = p4;
            type = "4 ugla ";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            p = new Point[5];
            this.p[0] = p1;
            this.p[1] = p2;
            this.p[2] = p3;
            this.p[3] = p4;
            this.p[4] = p5;
            type = "5 ugla ";
        }
    }
}
