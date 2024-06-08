using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Squareroot:Operation,IUnaryOperation
    {
        public Squareroot() : base("SquareRoot","sqrt","Calculate the square root of the number")
        { 
        }
        public double Calculate(double num)
        {
            return Math.Sqrt(num);
        }
    }
}
