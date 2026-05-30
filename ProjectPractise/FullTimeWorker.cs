using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class FullTimeWorker: Worker
    {
        internal FullTimeWorker(string name): base(name)
        {

        }

        internal override void CalculateSalary()
        {
            Console.WriteLine($"{Name} salary = 50000");
            // Implement salary calculation logic here
        }
    }
}
