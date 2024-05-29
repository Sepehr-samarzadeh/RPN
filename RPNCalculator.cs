using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class RPNCalculator : ICalculator
    {
        public List<string> helper = new List<string>();
       public List<string> supportedOperators = new List<string>();


        public RPNCalculator()
        {
            this.supportedOperators = new List<string> { "+", "-", "*", "/", "^", "sqrt", "exp", "ln" };
            this.helper = new List<string>
            {
              "+ - (Addition) adds two numbers",
              "- - (Subtraction) subtracts two numbers",
              "* - (Multiplication) multiplies two numbers",
              "/ - (Division) calculates the fraction of two numbers",
              "ˆ - (Power) calculates the power of two numbers",
              "sqrt - (SquareRoot) calculates the square root of a number",
              "exp - (Exponentiation) calculates the exponent with the natural base e",
              "ln - (Logarithm) calculates the natural logarithm of a number"
            };
        }

        public double Calculate (List<Token> tokens)
        {
            Stack<double>numberStack = new Stack<double>();
           foreach (Token token in tokens)
            {
                if(token.Type == TokenType.numberType)
                {
                    numberStack.Push(token.NumericValue);
                }
                else
                {
                    var theOperator = token.InputValue;
                    switch (theOperator)
                    {
                        case "+":
                            if(numberStack.Count < 2) //is this logic correct?
                            {
                                throw new ArgumentOutOfRangeException("there is not enogh numbers!");
                            }
                            var num2 = numberStack.Pop();
                            var num1 = numberStack.Pop();
                            numberStack.Push(num1 + num2);
                            break;
                            case "-":
                            num2 = numberStack.Pop();
                            num1 = numberStack.Pop();
                            numberStack.Push(num1 - num2);
                            break;
                            case "*":
                            num2 = numberStack.Pop();
                            num1 = numberStack.Pop();
                            numberStack.Push(num1 * num2);
                            break;
                            case "/":
                            num2 = numberStack.Pop();
                            num1 = numberStack.Pop();
                            numberStack.Push(num1 / num2);
                            break;
                        case "^":
                            num2 = numberStack.Pop();
                            num1 = numberStack.Pop();
                            numberStack.Push(Math.Pow(num1, num2));
                            break;
                        case "sqrt":
                            num1 = numberStack.Pop();
                            numberStack.Push(Math.Sqrt(num1));
                            break;
                        case "exp":
                            num1 = numberStack.Pop();
                            numberStack.Push(Math.Exp(num1));
                            break;
                        case "ln":
                            num1 = numberStack.Pop();
                            numberStack.Push(Math.Log(num1));
                            break;
                        default:
                            throw new Exception("errrr");
                      
                           

                            


                    }
                }
            }
            
            if(numberStack.Count == 1)
            {
                return numberStack.Pop();
            }
            else
            {
                throw new Exception("err");
            }
        }

    }
}
