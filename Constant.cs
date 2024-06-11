using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Constant : Operation,INullaryOperation
    {
 
        public double Value { get;}
        public Constant(string name,string operatorsimbol,string descript,double value) : base(name,operatorsimbol, descript)
        {
            Value = value;
        }
    }
}
