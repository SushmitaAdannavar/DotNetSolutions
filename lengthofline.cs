using System;

namespace lengthofline
{
    internal class Program
    {
        public double linelength(int x1,int y1,int x2,int y2)
        {
            double length;
            length = Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of line is: " + length);
            return length;
        }
        
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Program program = new Program();
            Console.WriteLine("Enter the coordinates of line1 x1,y1,x2,y2");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            double length1 = program.linelength(x1, y1, x2, y2);
            Console.WriteLine("Enter the coordinates of line2 x1,y1,x2,y2");
            int X1 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            double length2 = program.linelength(X1, Y1, X2, Y2);
            if (length1>length2)
            {
                Console.WriteLine("First line length is bigger");
            }
            else if(length2>length1)
            {
                Console.WriteLine("Second line length is bigger");
            }
            else
            {
                Console.WriteLine("Both line lengths are equal");
            }
        }
    }
}
