using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Addition : Operation,IBinaryOperation
    {
        public Addition() : base("Addition","+","addition of two number")
        {

        }

        public double Calculate(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
