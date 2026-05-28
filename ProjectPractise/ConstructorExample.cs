using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class ConstructorExample
    {
        static ConstructorExample()
        {
            Console.WriteLine("static Constructor");
        }
        internal ConstructorExample()
        {
            Console.WriteLine("Default Constructor");
        }

        internal ConstructorExample(int x)
        {
            Console.WriteLine("Parameterized Constrcutor: " + x);
        }
    }
}
