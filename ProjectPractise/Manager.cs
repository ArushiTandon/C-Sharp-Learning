using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class Manager: Admin
    {
        public double salary;
        public Manager(int id, string name, double salary) 
            : base(id, name)
        {
            this.salary = salary;
            
        }
    }
}
