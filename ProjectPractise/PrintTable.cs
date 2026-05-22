using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class PrintTable
    {
        public void Print(int num)
        {

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
}
