using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            // Operand is an object - a variable or expression that are manipulated.
            // Every expression has at least 1 operand

            // Operator is a symbol that signifies an operation to be performed in an expression

            // Expression is a sequence of one or more operands and zero or more operators that can be evaluated to a single value, object, method, or namespace.

            // X and 5 are operands, = is assignment operator. The entire line of code is an expression


            // assignment operator

            int x = 5;

            // addition, division,multiplication,

            int y = x + 10 / (10 - 5) * 7;

            // conditional AND; MORE THAN; IS NOT

            if( x > y && x != 0)
            {

            }

            // conditional OR; LESS THAN; EQUALS; ADDITION

            if (x < y || x == 0)
            {
                x += y;
            }

            // conditional operator  ?:

            int count = 2;

            string message = (count == 1) ? "Count is 1" : "Count is not 1";

        }
    }
}
