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
            Node n3 = new Node("hello");
            ll.AddAtLast(n3);
            Node n4 = new Node(10);
            Node n5 = new Node(15);
            ll.AddAtFront(n4);
            ll.InsertAfter(n4, n5);
            ll.Transverse();
            ll.DeleteFromPosition(4);
            Console.WriteLine("After Deletion");
            ll.Transverse();

        }
    }

    public class Node
    {
        public Node Next;
        public object Value;
        public Node(object value)
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

        #region Deletion
        public void Deletion(object key)
        {

            Node temp = head;
            //Deletion at the start
            if (temp.Value.Equals(key))
            {
                head = head.Next;
                count--;
            }
            else
            {

                Node prev = null;
                while (temp != null)
                {
                    if (temp.Value.Equals(key))
                        break;
                    prev = temp;
                    temp = temp.Next;
                }


            }
        }

        public void DeleteFromPosition(int i)
        {
            if (i == 0)
            {
                this.head = this.head.Next;
                this.count--;
            }
            else
            {
                Node temp = this.head;
                Node prev = null;
                int count = 0;
                while (temp != null)
                {

                    if (count == i)
                        break;
                    prev = temp;
                    temp = temp.Next;
                    count++;

                }
                if (temp == null)
                {
                    Console.WriteLine("Position Not exists");
                }
                else
                {
                    prev.Next = temp.Next;
                    this.count--;
                }
            }
        }

        #endregion


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
    
