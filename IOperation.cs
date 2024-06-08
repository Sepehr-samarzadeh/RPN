using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public interface IOperation
    {
        public string Name { get;}

        public string Operator { get;}
        public string Description { get;}
    }
}
