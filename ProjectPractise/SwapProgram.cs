using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class SwapProgram
    {
        static int a = 5, b = 10;
        internal static void Swap()
        {

            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping: a = " + a + " b = " + b);

        }
    }
}
