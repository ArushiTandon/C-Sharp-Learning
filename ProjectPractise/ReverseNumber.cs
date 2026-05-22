using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class ReverseNumber
    {
        public void Reverse(int num)
        {
            String rev = "";
            while(num > 0)
            {
               
                rev = rev + num % 10;
                num = num / 10;

            }

            Console.WriteLine(rev);
        }
    }
}
