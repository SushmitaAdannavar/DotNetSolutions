using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class AllStudent
    {
     public void Fees()
        {
            Console.WriteLine("All Student fees is 20000 each");
        }
    }
    public class StudentGrade : AllStudent
    {
        public void Grade()
        {
            Console.WriteLine("Grade acquired is A");
        }
    }
    public class StudentReport : StudentGrade 
    {
        public void Marks()
        {
            Console.WriteLine("Obtained marks is good");
        }
    }
}
