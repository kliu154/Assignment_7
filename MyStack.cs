using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class MyStack<T>
    {
        private List<T> Stack;

        public MyStack()
        {
            Stack = new List<T>();
        }

        public int Count()
        {
            return Stack.Count;
        }

        public T Pop()
        {
            if (Stack.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }

            T item = Stack[Stack.Count - 1];
            Stack.RemoveAt(Stack.Count - 1);

            return item;
        }

        public void Push(T item)
        {
            Stack.Add(item);
        }
    }
}
