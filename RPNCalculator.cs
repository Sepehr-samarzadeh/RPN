﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class RPNCalculator : ICalculator, ICollection<IOperation>
    {
        //public List<string> Helper = new List<string>();
        //public List<string> SupportedOperators = new List<string>();
        //public IList<string> SupportedOperators { get; }
        //public IList<string> OperationsHelp { get; }
        private readonly List<IOperation> _operations = new List<IOperation>();
        public IEnumerator<IOperation> GetEnumerator() { return _operations.GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
        public int Count => _operations.Count; //i was forced to use => instead of normal way why?? //is it possible to explain => one more time ( act as a function but pretteir int is a return value and its get the operration in front of the the arrow
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
        public void CopyTo(IOperation[] array, int index)
        {
            _operations.CopyTo(array, index);
        }
        public bool Remove(IOperation item)
        {
            return _operations.Remove(item);
        }



        public RPNCalculator()
        {
            //SupportedOperators = new List<string>();
            //OperationsHelp = new List<string>();
            //this.SupportedOperators = new List<string> { "+", "-", "*", "/", "^", "sqrt", "exp", "ln" };
            /*this.Helper = new List<string>
            {
              "+ - (Addition) adds two numbers",
              "- - (Subtraction) subtracts two numbers",
              "* - (Multiplication) multiplies two numbers",
              "/ - (Division) calculates the fraction of two numbers",
              "ˆ - (Power) calculates the power of two numbers",
              "sqrt - (SquareRoot) calculates the square root of a number",
              "exp - (Exponentiation) calculates the exponent with the natural base e",
              "ln - (Logarithm) calculates the natural logarithm of a number"
            };*/

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
                    IOperation op = null;
                    foreach (var operation in _operations)
                    {
                        if (operation.Operator.Equals(token.InputValue, StringComparison.OrdinalIgnoreCase))
                        {
                            op = operation;
                            break;
                        }
                    }
                    if (op != null)
                    {
                        switch (op)
                        {
                            case INullaryOperation nullyobj:// is it correct format ? one more with the help of the is ===> but forced me to use if statements -> if op is Inull.. nullyobj -> do your work
                                stack.Push(nullyobj.Value);
                                break;
                            case IUnaryOperation unaryobj:
                                var num = stack.Pop();
                                stack.Push(unaryobj.Calculate(num));
                                break;
                            case IBinaryOperation binaryobj:
                                var num2 = stack.Pop();
                                var num1 = stack.Pop();
                                stack.Push(binaryobj.Calculate(num1, num2));
                                break;
                        }
                        //if (op is INullaryOperation x)
                        //{
                        //    //INullaryOperation x = (INullaryOperation)op;
                        //    stack.Push(x.Value);
                        //}
                    }
                    else
                    {
                        throw new InvalidOperationException($"this one is unknown ~> {token.NumericValue}");
                    }
                }
            }
            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            else
            {
                throw new Exception("err");
            }
        }
        public IList<string> SupportedOperators => _operations.Select(op => op.Operator).ToList(); //one question! is it possible to iterate now ? we didnt use Ienumerate ?? why?? how??
        public IList<string> OperationsHelp => _operations.Select(op => op.Description).ToList();


    }
}
