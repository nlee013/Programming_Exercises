using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0524_Exercise3
{
   public class StackMY
    {
        private int[] num;
        private int top;
        private int max;

        public StackMY(int size)
        {
            num = new int[size];
            top = -1; // = 0;
            max = size;
        }


        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                num[++top] = item;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("{0}popped from stack", num[top]);
                return num[top--];
            }
            return num[top--];
        }

        public int Count()
        {
            return top;
        }

        //public  Clear()
        //{

        //}

        public void printStack()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("{0} pushed into stack", num[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            StackMY s = new StackMY(5);
            s.push(1);
            s.push(2);
            s.push(3);
          
            s.printStack();
            s.pop();
           
        }
    }
}
