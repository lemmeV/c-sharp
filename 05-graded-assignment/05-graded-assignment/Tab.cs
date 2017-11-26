using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_graded_assignment
{
    class Tab
    {
        public double subtotal { get; set; }

        public void Add(string itemSum)
        {
            subtotal += double.Parse(itemSum);
        }
    }
}
