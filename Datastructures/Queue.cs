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
        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
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

        public int Peek()
        {
            return LinkedList.head.data;
        }
        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            return stack.IsEmpty();
        }

        /// <summary>
        /// Emptyings the queue.
        /// </summary>
        public void Dequeue()
        {
            stack.EmptyingTheStack();
        }
    }
}
