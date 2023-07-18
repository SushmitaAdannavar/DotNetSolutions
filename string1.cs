using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class string1
    {
        public void strrev()
        {
            Console.WriteLine("Enter the string to be reversed");
            string str1 = Console.ReadLine();
            string str2="";
            for(int i=str1.Length-1;i>=0;i--)
            {
                
                
                    str2 = str2+str1[i];
                
            }
            Console.WriteLine("Reversed string is "+str2);
        }
    }
}
