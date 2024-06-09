using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public interface ICalculator
    {
        double Calculate(IEnumerable<Token> tokens);
        IEnumerable<string> SupportedOperators { get; }
        IEnumerable<string> OperationsHelp { get; }
    }
}
