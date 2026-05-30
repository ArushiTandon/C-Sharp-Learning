using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class Intern: Worker
    {
        internal Intern(string name): base(name)
        {

        }

        internal override void CalculateSalary()
        {
            Console.WriteLine($"{Name} stipend = 10000");
        }
    }
}
