using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class MyMatrix
    {
        int[][] matrix;
        public MyMatrix(int strok,int stolbec)
        {
            matrix = new int[strok][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[stolbec];
            }
            Random rnd = new Random();
            for (int i = 0; i < strok; i++)
            {
                for (int j = 0; j < stolbec; j++)
                {
                    matrix[i][j] = rnd.Next(0, 9);
                }
            }
            
            
        }

        public int Length(int index)
        {
            if (index == 0)
                return matrix.Length;
            else if (index == 1)
                return matrix[0].Length;
            return 0;
        }

        public void Show()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ChangeSize(int strok , int stolbec)
        {
            int[][] tmp = new int[strok][];
            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i] = new int[stolbec];
            }

            for (int i = 0; i < Math.Min(matrix.Length, strok); i++)
            {
                for (int j = 0; j < Math.Min(matrix[i].Length, stolbec); j++)
                    tmp[i][j] = matrix[i][j];
            }

            matrix = tmp;
        }



        public int this[int stroka, int stolbec  ]
        {
            get
            {
                return this.matrix[stroka][stolbec];
            }
            
        }
    }
}
