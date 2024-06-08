using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Division : Operation,IBinaryOperation
    {
        public Division() : base("Division", "/", "Performs the division of two numbers.")
        {
        }

        public double Calculate(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
