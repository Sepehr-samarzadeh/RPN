using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Logarithm:Operation,IUnaryOperation
    {
        public Logarithm() : base("Logarithm", "ln", "Calculates the natural logarithm of a number.")
        {
        }

        public double Calculate(double num)
        {
            return Math.Log(num);
        }
    }
}
