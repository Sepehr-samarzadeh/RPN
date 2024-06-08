using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Power : Operation,IBinaryOperation
    {
        public Power() : base("Power", "^", "calculates the power of two numbers") { }
        public double Calculate(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
