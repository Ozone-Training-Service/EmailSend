using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSend.Version1
{
    class arraysearch
    {
        static void Main(string[] args)
            {
            int n;
                int[] a = new int[10];
                Console.WriteLine("enter array elements");
                for (int i = 0; i < a.Length; i++)
                {

                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("enter search element");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < a.Length; i++)
                {
                if (n == a[i])
                {
                    Console.WriteLine("element found");
                    break;


                }
                else
                {
                    
                }

                }
           
            }
        
        }
}
