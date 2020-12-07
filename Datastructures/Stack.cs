using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class Stack
    {
        LinkedList linkedList;

        public Stack()
        {
            linkedList = new LinkedList();
        }

        /// <summary>
        /// Pushes the elements in to stack.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(int data)
        {
            Node node = new Node(data);
            linkedList.Add(data);

        }

        /// <summary>
        /// Returns the first element
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return this.linkedList.head.data;
        }

        /// <summary>
        /// Deletes the firstElement.
        /// </summary>
        public void Pop()
        {
            linkedList.Pop();
        }

        /// <summary>
        /// Emptyings the stack.
        /// </summary>
        public void EmptyingTheStack()
        {
            while (Size()!=0)
            {
                Pop();
            }
        }
        /// <summary>
        /// returns the size of an stack.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return linkedList.Size();
        }

        public bool IsEmpty()
        {
            if (Size() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
