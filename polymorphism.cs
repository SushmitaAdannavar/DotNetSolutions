using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class polymorphism
    {
        public virtual void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public  void Add(double a,double b,double c)
        {
            Console.WriteLine(a + b + c);
        }
    }
    public class Runtimepoly: polymorphism
    {
        public override void Add(int a,int b)
        {
            Console.WriteLine("Addition " + a + b);
        }
    }

}
