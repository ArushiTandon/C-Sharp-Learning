using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class BreakContinue
    {
        public void continueExample()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
