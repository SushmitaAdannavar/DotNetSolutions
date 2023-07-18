using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace EmployeeWage
{
    class Employee
    {
        public static int empno;
        public static string empName;
        public static string attendance="PA";
        public static char attendancestatus;
        public static int batch;
        public static int workhours=8;
        public static int wagesperhour=20;
        public static int wages;
        public static int monthlywages;
        public static void attendancecheck()
        {
            Console.WriteLine("Enter Employee num and Employee name");
            Employee.empno = Convert.ToInt32(Console.ReadLine());
            Employee.empName = Console.ReadLine();
            Random rand = new Random();
            int index = rand.Next(0, attendance.Length);
            attendancestatus = attendance[index];
            if(attendancestatus == 'P')
            {
                Console.WriteLine("Employee is present");
                DailyWage();
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
        public static void DailyWage()
        {
            Console.WriteLine("Enter batch 1.Full time 2.Part time");
            batch = Convert.ToInt32(Console.ReadLine());
            switch(batch)
            {
                case 1:wages = workhours * wagesperhour;
                       Console.WriteLine("Full time Employee daily wage is " + wages);
                       MonthlyWage(wages,empName);
                       break;
                case 2:wages = workhours * wagesperhour;
                       Console.WriteLine("Part time Employee daily wage is " + wages);
                      MonthlyWage(wages, empName); 
                      break;
            }

        }
        public static void MonthlyWage(int wages,string empName)
        {
            monthlywages = 0;
            for(int i=0;i<20;i++)
            {
                monthlywages = monthlywages + wages ;
               
            }
            Console.WriteLine("Monthly wage of " + empName + " is " + monthlywages);
        }
    }
}
