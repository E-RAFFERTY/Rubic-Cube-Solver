using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuby_5
{
    internal class Time_taken_node
    {
        public double data;
        public Time_taken_node left;
        public Time_taken_node right;

        public Time_taken_node(double value)
        {
            data = value;
            left = null;
            right = null;
        }
    }
}
