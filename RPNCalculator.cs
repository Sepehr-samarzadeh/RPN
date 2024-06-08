using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class RPNCalculator : ICalculator,ICollection<IOperation>
    {
        public List<string> Helper = new List<string>();
        //public List<string> SupportedOperators = new List<string>();
        private readonly List<IOperation>_operations = new List<IOperation>();
        public IEnumerator<IOperation>GetEnumerator() { return _operations.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
        public int Count => _operations.Count; //i was forced to use => instead of normal way why??
        public bool IsReadOnly => false;
        public void Add(IOperation operation)
        {
            _operations.Add(operation);
        }

        public void Clear()
        {
            _operations.Clear();
        }
        public bool Contains(IOperation operation)
        {
            return _operations.Contains(operation);
        }
        public void CopyTo(IOperation[] array, int arrayIndex)
        {
            _operations.CopyTo(array, arrayIndex);
        }
        public bool Remove(IOperation item)
        {
            return _operations.Remove(item);
        }



        public RPNCalculator()
        {
            //this.SupportedOperators = new List<string> { "+", "-", "*", "/", "^", "sqrt", "exp", "ln" };
            this.Helper = new List<string>
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

       /* public double Calculate(List<Token> tokens)
        {
            Stack<double> numberStack = new Stack<double>();
            foreach (Token token in tokens)
            {
                if (token.Type == TokenType.NumberType)
                {
                    numberStack.Push(token.NumericValue);
                }
                else
                {
                    var theOperator = token.InputValue;
                    switch (theOperator)
                    {
                        case "+":
                            if (numberStack.Count < 2) //is this logic correct?
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

            if (numberStack.Count == 1)
            {
                return numberStack.Pop();
            }
            else
            {
                throw new Exception("err");
            }
        }*/
        public double Calculate(IEnumerable<Token> tokens)
        {
            var stack = new Stack<double>();
            foreach (var token in tokens)
            {
                if (token.Type == TokenType.NumberType)
                {
                    stack.Push(token.NumericValue);
                }
                else
                {
                    var op = _operations.FirstOrDefault(o => o.Operator.Equals(token.InputValue, StringComparison.OrdinalIgnoreCase));
                    if (op != null)
                    {
                        if (op is INullaryOperation nullaryOp)
                        {
                            stack.Push(nullaryOp.Value);
                        }
                        else if (op is IUnaryOperation unaryOp)
                        {
                            var operand = stack.Pop();
                            stack.Push(unaryOp.Calculate(operand));
                        }
                        else if (op is IBinaryOperation binaryOp)
                        {
                            var operand2 = stack.Pop();
                            var operand1 = stack.Pop();
                            stack.Push(binaryOp.Calculate(operand1, operand2));
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException($"Unknown operation: {token.NumericValue}");
                    }
                }
            }

            return stack.Count == 1 ? stack.Pop() : throw new InvalidOperationException("Invalid expression");
        }

        public IEnumerable<string> SupportedOperators => _operations.Select(op => op.Operator);

        public IEnumerable<string> OperationsHelpText => _operations.Select(op => $"{op.Operator} - ({op.Name}) {op.Description}");


    }
}
