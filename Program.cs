using assignment2;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    
    private static void Main(string[] args)
    {
        var calculator = new RPNCalculator();
        var parser = new Parser(calculator.supportedOperators);
        var menu = new TextMenu(calculator.helper);
        var controller = new Controller(calculator, parser, menu);
        controller.Run();















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