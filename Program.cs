using System.Collections.Generic;

namespace DataStructureLinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(70);
            list.Display();
            list.Insert(30, 56);
            list.Display();
            list.DeleteLast();
            list.Display();
        }
    }
}