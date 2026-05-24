using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class Loops
    {
        public void Pattern()
        {

            for ( int i = 5; i >= 0; i--)
            {
                char ch = 'A';

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(ch++);
                }
                Console.WriteLine();
            }
        }
    }
}
