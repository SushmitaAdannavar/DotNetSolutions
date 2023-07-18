using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class problem
    {
        public static void integerequal()
        {
            Console.WriteLine("Enter the integers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Both integers are equal");
            }
            else
            {
                Console.WriteLine("Both integers are not equal");
            }
        }
        public static void votecast()
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("Eligible to cast vote");

            }
            else
            {
                Console.WriteLine("not eligible to cast vote");
            }
        }
        public static void greatestnum()
        {
            Console.WriteLine("Enter 3 numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("First number is greater");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Second number is greater");
            }
            else
            {
                Console.WriteLine("Third number is greater");
            }
        }

    }
}
