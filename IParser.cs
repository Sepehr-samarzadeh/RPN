using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public interface IParser
    {
         List<Token> Lex(List<string> tokenizedValue);
         List<string> Tokenize(string input);
    }
}
