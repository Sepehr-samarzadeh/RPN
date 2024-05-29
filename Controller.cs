using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Controller
    {
        private ICalculator Calculator;
        private IParser Parser;
        private IMenu Menu;
        public Controller(ICalculator calc, IParser parser, IMenu menu)
        {
            this.Calculator = calc;
            this.Parser = parser;
            this.Menu = menu;
        }
        public void Run()
        {
            Menu.ShowMenu();
            var input = string.Empty;
            do
            {
                Console.Write("> ");
                input = Console.ReadLine() ?? "quit";
                switch (input)
                {
                    case "q":
                        break;
                    case "h":
                        Menu.ShowHelp();
                        break;
                    case "o":
                        Menu.ShowOperations(["+", "-", "*", "/", "^", "sqrt", "exp", "ln"]);
                        break;
                    default:
                        // an RPN expression is expected here
                        try
                        {
                            var split = Parser.Tokenize(input);
                            if (split.Count != 0)
                            {
                                var tokens = Parser.Lex(split);
                                var result = Calculator.Calculate(tokens);
                                Console.WriteLine($"\n {result}\n");
                            }
                        }
                        // if the input is not valid, an exception is thrown by calculator or parser
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
            } while (!input.ToLower().Equals("q"));
            Console.WriteLine("\n Calculator is quitting. Bye!");
        } 

    }
}
