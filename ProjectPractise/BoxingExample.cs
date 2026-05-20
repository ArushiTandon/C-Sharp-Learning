using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class BoxingExample
    {

        internal void Boxingfun()
        {
            int a = 10;
            Object o;
            o = a;
            Console.WriteLine(o);
        }

        internal void UnBoxingfun()
        {
            Object o = 10;
            int a = (int)o;
            Console.WriteLine(a);

        }
    }
}
