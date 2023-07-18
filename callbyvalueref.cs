using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class callbyvalueref
    {
        public void swap1(int x,int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After swap "+x+"  "+y);
        }
        public void swap2(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After swap "+x + "  " + y);
        }

    }
}
