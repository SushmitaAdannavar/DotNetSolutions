using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*StudentGrade sd1 = new StudentGrade();
            sd1.Fees();
            sd1.Grade();*/
            /*StudentReport sd2 = new StudentReport();
            sd2.Fees();
            sd2.Grade();
            sd2.Marks();*/
            /*polymorphism ph = new polymorphism();
            ph.Add(1,2);
            ph.Add(10.2,11.1,15.6);
            */

           int a = 10, b = 20;
            Console.WriteLine(a+" "+b);
            callbyvalueref sw = new callbyvalueref();
            sw.swap2(ref a, ref b);
            
            Console.WriteLine("Now Values of a and b are " + a + " " + b);
            sw.swap1(a, b);
            

            

        }
    }
}
