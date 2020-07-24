using System;
using System.Collections.Generic;
using System.Text;

namespace EmailSend.Version1
{
    class array_search
    {
        static void Main(string[] args)
        {
            int n, flag=0;
            int[] a = new int[10];
            Console.WriteLine("Enter array elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter search element");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                if(n==a[i])
                {
                    Console.WriteLine("Element found ");
                    break;
                }
                else
                {
                    flag++;
                }
                
            }
            if(flag==9)
            {
                Console.WriteLine("Element not found ");
            }

        }
    }
}
