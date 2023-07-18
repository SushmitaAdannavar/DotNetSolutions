using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] intarray = { 1, 2, 3 };
            double[] doublearray = { 1.8, 2.3, 3.4 };
            generics gn = new generics();
            gn.displayelements(intarray);
            Console.WriteLine();
            gn.displayelements(doublearray);*/

            generics2<int> inttype = new generics2<int>(1);
            generics2<double> doubletype = new generics2<double>(1.7);
            generics2<string> stringtype = new generics2<string>("string value");

        }
    }
}
