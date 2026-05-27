using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class Employee
    {
        private int empId;
        private String empname;
        private int age;

        internal void Accept(int empid, String empname, int age)
        {
            this.empId = empid;
            this.empname = empname;
            this.age = age;

        }

        internal void Display()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Name: " + empname);
            Console.WriteLine("Employee Age: " + age);
        }

    }
}
