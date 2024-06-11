using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class TextMenu : IMenu
    {
        public IList<string> Help {  get;}
        public TextMenu(IList<string>listOfHelps) {
            this.Help = listOfHelps;
        }

        public void ShowMenu()
        {
            Console.WriteLine("RPN Calculator");
            Console.WriteLine("Enter an RPN expression to evaluate");
            Console.WriteLine("Enter '(h)elp' for help");
            Console.WriteLine("Enter '(o)ps' for available operations");
            Console.WriteLine("Enter '(q)uit' to exit");

        }

        public void ShowOperations(List<string> opHelp)
        {
            Console.WriteLine("Calculator operations:");
            foreach (var operation in opHelp)
            {
                Console.WriteLine(operation);
            }
        }
        public void ShowHelp()
        {
            Console.WriteLine("Enter expressions using RPN notation, for instance to calculate:");
            Console.WriteLine("2 + 3 * 4");
            Console.WriteLine("enter '2 3 4 * +'");
            Console.WriteLine("or enter '3 + 4 * 2 +'");
            Console.WriteLine("enter (o)ps to see available operations");
        }
    }
}
