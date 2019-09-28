using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_6
{
    class Program
    {
        class MyStack<T> where T : struct
        {
            int stackTop = 0;
            T[] items = new T[100];
            public void Push(T item)
            {
                if (stackTop == items.Length)
                    throw new Exception("Stack full");
                items[stackTop] = item;
                stackTop++;
            }
            public T Pop()
            {
                if (stackTop == 0)
                    throw new Exception("Stack empty");
                stackTop--;
                return items[stackTop];
            }
        }
        static void Main(string[] args)
        {
            MyStack<string> nameStack = new MyStack<string>();
            MyStack<int> mystack2 = new MyStack<int>();
            mystack2.Push(9);
            Console.WriteLine(mystack2.Pop());
            nameStack.Push("Rob");
            nameStack.Push("Mary");
            Console.WriteLine(nameStack.Pop());
            Console.WriteLine(nameStack.Pop());
            Console.ReadKey();
        }
    }
}
