using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Parser:IParser
    {
        public IList<string> supportedOperators = new List<string>();

        public Parser(IList<string>listOfOperators) {
            this.supportedOperators = listOfOperators;
        }

        public List<string> Tokenize(string input) {
            List<string> result = new List<string>();
            if (input == null) {
                throw new ArgumentNullException($"null is not acceptable for {input}");
            }

            var splitedValues = input.Split(' '); 
            foreach ( var split in splitedValues)
            {
                result.Add(split);
            }
            return result;
        
        }
        public List<Token> Lex(List<string> tokenizedValue) {
            if (tokenizedValue == null)
            {
                throw new ArgumentNullException("it cant be null!Err!!");
            }
            List<Token> tokenList = new List<Token>();
            foreach ( var token in tokenizedValue)
            {
                if(double.TryParse(token,out double number)){
                    tokenList.Add(new Token(token,TokenType.NumberType));
                }else if (supportedOperators.Contains(token))
                {
                    tokenList.Add(new Token(token,TokenType.OperatorType));
                }else
                {
                    throw new ArgumentException($"this {token} is not valid (its not number or recognized operator)");
                }
            }
            return tokenList;
            
        }

    }
}
