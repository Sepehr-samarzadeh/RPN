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
        public IList<string> SupportedOperators {  get; }
        public IList<string> OperationsHelp {  get; }
    }
}
