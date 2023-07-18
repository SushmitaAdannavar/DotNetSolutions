using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class sum
    {
        public void sumof()
        {
            int i = 1,sum=0;
            while(i <= 5)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine("Sum is " + sum);

        }
    }
}
