using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Subtraction : Operation,IBinaryOperation
    {
        public Subtraction() : base("Subtraction", "-", "Performs the subtraction of two numbers.")
        {
        }

        public double Calculate(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
