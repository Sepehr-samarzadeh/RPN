using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Constant : Operation,INullaryOperation
    {
        //The derived class constructor often calls the base class
        //constructor to ensure that the base class is correctly set up
        public double Value { get;}
        public Constant(string name,string operatorsimbol,string descript,double value) : base(name,operatorsimbol, descript)
        {
            Value = value;
        }
    }
}
