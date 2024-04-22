using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Calculator
    {
        public int Calculate(string op, int value1, int value2)
        {
            if (op == "+")
            {
                return value1 + value2;
            }

            else if (op == "-")
            {
                return value1 - value2;
            }

            else if (op == "*") 
            {
                return value1 * value2;
            }

            else if(op == "/") 
            {
                return value1 / value2;
            }
            return 0;
        }
    }
}
