using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class Emp: Manager
    {
            public int incentive;
        public Emp(int id, string name, double salary, int incentive)
            : base(id, name, salary)
        {
            this.incentive = incentive;
        }
    }
}
