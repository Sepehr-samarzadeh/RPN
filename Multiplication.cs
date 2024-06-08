using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Multiplication : Operation,IBinaryOperation
    {
        public Multiplication() : base("Multiplication", "*", "Performs the multiplication of two numbers.")
        {
        }

        public double Calculate(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
