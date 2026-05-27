using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractise
{
    internal class InstanceExample
    {
        internal int x = 100; //global instance

        internal void fun1()
        {
            int y = 200; //local instance
        }
    }
}
