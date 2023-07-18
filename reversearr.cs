using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class reversearr
    {
        public void arr1()
        {
            int[] arr = new int[3];
            arr[0]=2;
            arr[1] = 5;
            arr[2] = 7;
           
            int[] rev = new int[3];
            for(int i=2;i>=0;i--)
            {
                for(int j=0;j<4;j++)
                {
                    rev[j] = arr[i];
                    Console.Write(rev[j] + "");
                    break;
                }
               
            }
            Console.WriteLine(rev);
            

        }
    }
}
