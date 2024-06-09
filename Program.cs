using assignment2;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    
    private static void Main(string[] args)
    {
        /*var calculator = new RPNCalculator();
        var parser = new Parser(calculator.SupportedOperators);
        var menu = new TextMenu(calculator.Helper);
        var controller = new Controller(calculator, parser, menu);
        controller.Run();

*//*
        var ops = new List<IOperation>();
        ops.Add(new Addition());
        ops.Add(new Subtraction());
        ops.Add(new Multiplication());
        ops.Add(new Division());
        ops.Add(new Squareroot());
        ops.Add(new Logarithm());
        ops.Add(new Constant("pi", "pi", "constant pi", Math.PI));
        ops.Add(new Constant("e", "e", "constant e", Math.E));
        foreach (var op in ops)
        {
            double lhs = 2.0;
            double rhs = 3.0;
            switch (op)
            {
                case INullaryOperation nullaryOp:
                    Console.WriteLine($"I am a constant {nullaryOp.Name} with a value of {nullaryOp.Value}");


            break;
                case IUnaryOperation unaryOp:
                    Console.WriteLine($"I am an unary operation {unaryOp.Name}and can calculate:{unaryOp.Operator} {rhs} ->{unaryOp.Calculate(rhs)}");
            break;
                case IBinaryOperation binaryOp:
                    Console.WriteLine($"I am a binary operation {binaryOp.Name} and can calculate:{lhs} {binaryOp.Operator} {rhs} -> {binaryOp.Calculate(lhs, rhs)}");
            break;
                    }
        }*/

        var calculator = new RPNCalculator();
        calculator.Add(new Addition());
        calculator.Add(new Subtraction());
        calculator.Add(new Multiplication());
        calculator.Add(new Division());
        calculator.Add(new Power());
        calculator.Add(new Squareroot());
        calculator.Add(new Logarithm());
        calculator.Add(new Constant("pi", "pi", "constant pi", Math.PI));
        calculator.Add(new Constant("e", "e", "constant e", Math.E));
        var parser = new Parser(calculator.SupportedOperators);
        var menu = new TextMenu(calculator.OperationsHelp);
        var controller = new Controller(calculator, parser, menu);
        controller.Run();


        //when we have interfaces why we doing the polymorphys?
        //is the virtual and overriding count as polymorph?














        //Console.WriteLine("please write your tokens: ");
        //string askuser = Console.ReadLine();
        //var askUsers = askuser.Split(" ");
        //List<int>num = new List<int>();
        /* foreach ( var str in askUsers ) {


         }
         int total = 0;
         for(int i = 0; i < num.Count; i++)
         {
             total += num[i];
         }

         Console.WriteLine(total);
         */

        /*string str = "allaho akbar";
        bool result = Int32.TryParse(str, out int addad);
        if (result)
        {
            Console.WriteLine("yeay");
        }else
        {
            Console.WriteLine("something is wrog");
        }*/
        /*   List<string>mylist = new List<string>();
           List<char>myoperator = new List<char>();
           int total = 0;
           mylist.Add("12");
           mylist.Add("20");
           mylist.Add("+");
           foreach(string member in mylist)
           {
               if(int.TryParse(member,out int anynumber))
               {
                   total+=Convert.ToInt32(member);
               }
               else
               {
                   Console.WriteLine("this is the operator : ");
                   Console.WriteLine(member);
                   var chararr = member.ToCharArray();
                   Console.WriteLine(chararr[0]);
               }
           }

           Console.WriteLine(total);*/
        /*Stack<int> stack = new Stack<int>();
         stack.Push(1);
         stack.Push(2);
         stack.Push(3);
         stack.Push(4);
         stack.Push(5);
         stack.Push(6);
         Console.WriteLine(stack.Peek());
         var turntoarray = stack.ToArray();
         Console.WriteLine(turntoarray[5]);
         Console.WriteLine(stack.Pop());*/
        //["number","number","operator","result"]   ===> now pop the result and show it to user
        //write a total variable and calculate then add it to the stack


    }
}