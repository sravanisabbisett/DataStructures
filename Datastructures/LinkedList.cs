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
        public void Add(int data)
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
        public void Append(int data)
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

        /// <summary>
        /// Inserts the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="data">The data.</param>
        public void Insert(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                try
                {
                    while (position > 2)
                    {
                        temp = temp.next;
                        position--;
                    }
                    node.next = temp.next;
                    temp.next = node;
                }
                catch (NullReferenceException)
                {
                    System.Console.WriteLine("Index out of bounds");
                }
            }
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns></returns>
        public Node Pop()
        {
            if (head == null)
            {
                Console.WriteLine("No elemnent in list");
                return null;
            }

            Node tempNode = head;
            head = head.next;
            return tempNode;
        }

        /// <summary>
        /// Pops the last element in the list
        /// </summary>
        /// <returns></returns>
        public Node PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return null;
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                Node finalNode = temp.next;
                temp.next = null;
                this.tail = temp;
                return finalNode;
            }
        }

        /// <summary>
        /// Searches the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public int Search(int data)
        {
            Node temp = head;
            while(temp != null)
            {
                if (temp.data == data)
                {
                    return temp.data;
                }
                temp = temp.next;
            }
            return 0;
        }

        /// <summary>
        /// Deletes the specified item in list.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Delete(int element)
        {
            Node temp = head, previous = null;
            if (temp != null && temp.data == element)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != element)
            {
                previous = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            previous.next = temp.next;
        }
        /// <summary>
        /// Sizes this list.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Node tempNode = this.head;
            int size = 0;
            while (tempNode != null)
            {
                size++;
                tempNode = tempNode.next;
            }
            return size;
        }
    }
}
