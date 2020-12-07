using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class Queue
    {
        LinkedList LinkedList;
        Stack stack;
        public Queue()
        {
            LinkedList = new LinkedList();
            stack = new Stack();
        }

        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (IsEmpty())
            {
                LinkedList.Add(data);
            }
            else
            {
                LinkedList.Append(data);
            }
        }

        public bool IsEmpty()
        {
            return stack.IsEmpty();
        }
    }
}
