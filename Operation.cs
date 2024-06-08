using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Operation : IOperation
    {
        public string Name { get;}
        public string Operator { get;}
        public string Description { get;}

        public Operation (string name, string op, string description)
        {
            Name = name;
            Operator = op;
            Description = description;
        }
    }
}
