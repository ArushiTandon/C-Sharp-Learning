using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class Student
    {
        internal int roll_no;
        internal int fees;

    internal void Accept(int r_no, int fees)
        {
            this.roll_no = r_no;
            this.fees = fees;

        }

        internal void Display()
        {
            Console.WriteLine("Roll No: " + roll_no);
            Console.WriteLine("Fees: " + fees);
        }
    }

}
