using System;

namespace leapyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year");
            year= Convert.ToInt32(Console.ReadLine());
            if(year%100 ==0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("It is a leap year");
                }
                else
                    Console.WriteLine("It is not leap year");
            }
            else
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("It is leap year");
                }
                else
                    Console.WriteLine("It is not leap year");
            }

        }
    }
}
