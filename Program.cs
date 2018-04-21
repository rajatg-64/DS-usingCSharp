using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList(20);
            Node n2 = new Node(30);
            ll.AddAtLast(n2);
            Node n3 = new Node(40);
            ll.AddAtLast(n3);
            Node n4 = new Node(10);
            Node n5 = new Node(15);
            ll.AddAtFront(n4);
            ll.InsertAfter(n4, n5);
            ll.Transverse();

        }
    }

    public class Node
    {
        public Node Next;
        public object Value;
        public Node(Object value)
        {
            this.Value = value;
        }
    }
    public class LinkedList
    {
        private Node head;
        private Node current;
        public int count;
        public LinkedList(object value)
        {
            head = new Node(value);
            current = head;
            count++;
        }

        #region Insertion
        public void AddAtLast(Node node)
        {
            current.Next = node;
            current = node;
            count++;
        }

        public void AddAtFront(Node node)
        {
            node.Next = head;
            head = node;
            count++;
        }

        public void InsertAfter(Node prev, Node newNode)
        {
            if (prev == null)
            {
                Console.WriteLine("Given previous node must be in LinkedList");
            }
            else
            {
                newNode.Next = prev.Next;
                prev.Next = newNode;
                count++;
            }
        } 
        #endregion

        public void Transverse()
        {
            Node temp = head;
            Console.WriteLine(temp.Value);
            while(temp.Next!= null)
            {
                temp = temp.Next;
                Console.WriteLine(temp.Value);                
            }

            Console.WriteLine("Count of LinkedList: "+ count);
        }
    }
}
    