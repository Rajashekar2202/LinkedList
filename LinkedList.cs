using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    public class LinkedList
    {
        Node head;
        Node current;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = this.head;
                this.head = node;
            }
            Console.WriteLine("{0} data is Inserted ", node.data);
        }
        public void Append(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} data is inserted ", node.data);
        }
        public void Insert(int data, int posVal)
        {
            Node node = new Node(data);
            Node temp = this.head;

            while (temp != null)
            {
                if (temp.data == 56)
                {
                    node.next = temp.next;
                    temp.next = node;
                    Console.WriteLine("New data is inserted in between 56 and 70");
                    break;
                }
                temp = temp.next;
            }
        }
        public void DeleteFirst()
        {
            Node temp = this.head;

            if (temp.next != null)
            {
                head = temp.next;
                temp.next = null;
            }
            else
            {
                head = null;
            }
        }
        public void DeleteLast()
        {
            Node temp = this.head;
            Node temp2 = this.head;

            if (head.next == null)
            {
                head = null;
            }
            while (temp.next != null)
            {
                temp = temp.next;
            }
            while (temp2 != null)
            {
                if (temp2.next == temp)
                {
                    temp2.next = null;
                }
                temp2 = temp2.next;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}