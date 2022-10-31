﻿using System;
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

        public void InsertAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                this.head = newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
        }

        public Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        public Node RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        public int findNodeWithValue(int value)
        {
            bool flag = true;
            int count = 1;
            Node temp = head;
            while (flag)
            {
                if (temp.data == value)
                {
                    flag = false;
                }
                else
                {
                    temp = temp.next;
                    count++;
                }
            }
            return count;
        }
        public void AddAfterAtPerticulatPosition(int data)
        {
            Node newnode = new Node(40);
            Node temp = head;

            while (temp.next != null)
            {
                if (temp.data == data)
                {
                    newnode.next = temp.next;
                    temp.next = newnode;
                }
                temp = temp.next;
            }
            Console.WriteLine("Given LinkedList = " + head.data);
        }

    }
}