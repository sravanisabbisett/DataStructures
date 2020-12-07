using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class LinkedList
    {
       public Node head;
       public Node tail;
        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        /// <summary>
        /// Adds the data at the data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void add(int data)
        {
            Node node = new Node(data);
            if (this.tail == null)
            {
                tail = node;
            }
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node tempNode = this.head;
                this.head = node;
                this.head.next = tempNode;
            }
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            if (head == null)
                System.Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }

        /// <summary>
        /// Appends the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            if (this.tail == null)
            {
                this.tail = node;
            }
            else
            {
                this.tail.next = node;
                this.tail = node;
            }
        }

        public int CheckFirstElement()
        {
            return this.head.data;
        }

        public int CheckLastElement()
        {
            return this.tail.data;
        }

        public int CheckMiddleElement()
        {
            return this.head.next.data;
        }
    }
}
