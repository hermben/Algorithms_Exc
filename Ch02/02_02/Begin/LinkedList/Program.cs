using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.InsertFirst(100);
            myList.InsertFirst(50);
            myList.InsertFirst(99);
            myList.InsertFirst(88);
            myList.InserLast(999000);
            myList.DisplayList();

            myList.DeleteFirst();
            myList.DisplayList();
        }
    }
    public class SinglyLinkedList
    {
        private Node first;
        public bool IsEmpty()
        {
            return (first == null);
        }
        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }
        public Node DeleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }
        public void DisplayList()
        {
            Console.WriteLine("List (first -- last) ");
            Node current = first;
            while (current != null)
            {
                current.DisplayaNode();
                current = current.next;
            }
            Console.WriteLine();
        }
        public void InserLast(int data)
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }
    public class Node
    {
        public int data;
        public Node next;

        public void DisplayaNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }

}
