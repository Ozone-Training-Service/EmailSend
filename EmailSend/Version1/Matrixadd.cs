using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSend.Version1
{
    public class Matrixadd
    {

        public void MatrixOpertions()
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] c = new int[2, 2];
            Console.WriteLine("Enter first 2X2 matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Second 2X2 matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //matrix addition
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = a[i,j]+b[i,j];
                }
            }
            //result

            Console.WriteLine("\n\n\n\t\toutput");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(c[i, j] + "  ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
