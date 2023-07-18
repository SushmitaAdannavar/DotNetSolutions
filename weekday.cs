using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class weekday
    {
        public static void dayname()
        {
            Console.WriteLine("Enter the weekday number");
            int weekdaynum = Convert.ToInt32(Console.ReadLine());
            switch(weekdaynum)
            {
                case 1:Console.WriteLine("It is Monday");
                       break;
                case 2:Console.WriteLine("It is Tuesday");
                       break;
                case 3:Console.WriteLine("It is Wednesday");
                        break;
                case 4:Console.WriteLine("It is Thursday");
                        break;
                case 5:Console.WriteLine("It is Friday");
                        break;
                case 6:Console.WriteLine("It is Saturday");
                    break;
                case 7:Console.WriteLine("It is Sunday");
                    break;
                default:Console.WriteLine("Enter valid weekday");
                    break;

            }
        }

    }
}
