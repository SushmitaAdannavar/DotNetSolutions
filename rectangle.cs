using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class rectangle
    {
        int length, breadth;
        public static string name;
        public rectangle()   //this is default constructor
        {
            length = 2;
            breadth = 4;
            int area = length * breadth;
            Console.WriteLine("Area of "+name+" is "+area);
        }
        public rectangle(int length,int breadth) //parameterised constructor
        {
            this.length = length;
            this.breadth = breadth;
            int area = length * breadth;
            Console.WriteLine("Area of rectangle is " + area);
        }
      
        public rectangle(rectangle rect4) //copy constructor
        {
            length = rect4.length;
            breadth = rect4.breadth;
            int area = length * breadth;
            Console.WriteLine("Area of third rectangle is " + area);
        }
        /* private rectangle() //private constructor
         {
             Console.WriteLine("private constructor");
         }*/
        static rectangle() //static constructor
        {
            name = "rectangle";
        }
    }
}
