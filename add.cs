using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface Iaddition
    {
        void add();
    }
    public class add1 : Iaddition
    {
        public void add()
        {
            Console.WriteLine("It adds 2 numbers");
        }
    }
    public class add2 : Iaddition
    {
        public void add()
        {
            Console.WriteLine("It adds 3 numbers");
        }
    }
}
