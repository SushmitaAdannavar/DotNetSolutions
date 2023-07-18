using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class generics
    {
        public void displayelements<T>(T[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
    public class generics2<Th>
    {
        public generics2(Th value)
        {
            Console.WriteLine(value);
        }
    }
}
