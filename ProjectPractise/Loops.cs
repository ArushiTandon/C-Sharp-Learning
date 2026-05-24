using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class Loops
    {
        public void Pattern()
        {

            for(int i = 1; i <= 3; i++)
            {
                for( int space = 2; space >= i; space--)
                {
                    Console.Write(" ");
                }

                for(int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
