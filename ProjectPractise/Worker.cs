using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    abstract class Worker
    {
        internal string Name;

        internal Worker(string name)
        {
            Name = name;
        }

        internal abstract void CalculateSalary();
    }
}
