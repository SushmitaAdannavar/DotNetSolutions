using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Flipcoin
    {
        public void headstails()
        {
            int H = 0,T = 0;
           
            while(H != 1 || T != 1)
            {
                Random rand = new Random();
                int value = rand.Next(0, 2);
                if (value == 0)
                {
                    H=H+1;
                }
                else
                {
                    T=T+1;
                }
                
            } 
            Console.WriteLine("  head is 20");
        }
    }
}
