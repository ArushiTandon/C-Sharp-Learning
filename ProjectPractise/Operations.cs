using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class Operations
    {
        int a, b, c;

       internal void Accept()
        {
            Console.WriteLine("Enter First Number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        internal void Add()
        {
            c = a + b;
            Console.WriteLine(c);
        }
       
       internal void Subtract()
        {
            c = a - b;
            Console.WriteLine(c);
        }

        internal void Multiply()
        {
            c = a * b;
            Console.WriteLine(c);
        }
    }
}
