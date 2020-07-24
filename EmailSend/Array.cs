using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSend.Version1
{


    
        //int[] a = new int[10];

        //a[0] = 10;
        //a[9] = 22;

        //Console.WriteLine("Enter Array Elments");
        //for (int i = 0; i < a.Length; i++)
        //{
        //    a[i] = Convert.ToInt32(Console.ReadLine());
        //}


        //Console.WriteLine("output");

        ////            9>=0

        //for (int i=0;i<=5;i++)
        //{
        //    Console.WriteLine(a[i]);
        //}

        //// foreach
        //// array print
        ////Collection
        ////speed

        //Console.WriteLine("output");

        //foreach (var item in a)
        //{

        //    Console.WriteLine(item);
        //}
        class Array
        {

            static void Main(string[] args)
            {


                int[,] b = new int[2, 2];
                b[0, 0] = 10;

                Console.WriteLine("Enter a 2X2 matrix");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        b[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Tanspose");

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {

                        Console.Write(b[j, i] + "  ");// transpose

                        //Console.Write(b[i,j]+"  ");
                    }

                    Console.WriteLine("\n");
                }









                Console.ReadKey();
            }
        }
    }




