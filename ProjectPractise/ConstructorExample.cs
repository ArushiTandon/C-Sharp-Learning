using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class ConstructorExample
    {
        static int x, y;
        int a, b;

        static ConstructorExample()
        {
            x = 100;
            y = 200;
            Console.WriteLine("static Constructor" + (x + y));
        }
        internal ConstructorExample()
        {
            a = 100;
            b = 200;
            Console.WriteLine("Default Constructor" + (a - b));
        }

        internal ConstructorExample(int a, int b)
        {
            this.a = a;
            this.b = b;

            Console.WriteLine("Parameterized Constrcutor: " + (a * b));
        }
    }
}
