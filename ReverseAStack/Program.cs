using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAStack
{
    class Program
    {
        /***Reverse a stack and put the reversed value back in the same stack. 
        You can use only one other stack and a temp variable ***/

        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(4);
            stack1.Push(3);
            stack1.Push(2);
            stack1.Push(1);
            
            Stack<int> stack2 = new Stack<int>();
            int temp;

            for (int i = 0; i < stack1.Count - 1; i++)
            {
                temp = stack1.Pop();

                while (stack1.Count - i != 0)
                {
                    stack2.Push(stack1.Pop());
                }

                stack1.Push(temp);
                while (stack2.Count != 0)
                {
                    stack1.Push(stack2.Pop());
                }

            }

            while (stack1.Count != 0)
            {
                Console.WriteLine(stack1.Pop());
            }
            Console.ReadLine();



        }
    }
}

