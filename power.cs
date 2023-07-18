using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class power
    {
        public static void powerof2()
        {
            Console.WriteLine("Enter the value n");
            int n = Convert.ToInt32(Console.ReadLine());
            int pow = 1;
            Console.WriteLine("n       power of n");
            for(int i=0;i<=n;i++)
            {
                Console.WriteLine(i + "       " + pow);
                    pow = pow * 2;
            }
        }
    }
}
