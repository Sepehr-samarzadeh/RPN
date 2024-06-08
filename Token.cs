using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public enum TokenType
    {
        NumberType,
        OperatorType,
    }
    public class Token
    {
       public string InputValue {  get; set; }
       public TokenType Type { get; }
        public double NumericValue {  get; }

        public Token(string userInput, TokenType token_type)
        {
            this.InputValue = userInput;
            this.Type = token_type;
            if(token_type == TokenType.NumberType)
            {
                if(double.TryParse(userInput,out double doubleNumber)){
                    this .NumericValue = doubleNumber;
                }
            }
        }
    }
}
