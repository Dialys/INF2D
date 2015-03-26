using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
    public class CircularlyLinkedList
    {
        protected Node current;
        protected Node header;
        private int count;

        public CircularlyLinkedList()
        {
            count = 0;
            header = new Node("header");
            header.Link = header;
        }

        public bool IsEmpty()
        {
            return (header.Link == null);
        }

        public void MakeEmpty()
        {
            header.Link = null;
        }

        public void PrintList()
        {
            Node current = new Node();
            current = header;
            while (!(current.Link.Element = "header"))
            {
                Console.WriteLine(current.Link.Element);
                current = current.Link;
            }
        }

        private Node FindPrevious(Object n)
        {
            Node current = header;
            while (!(current.Link == null) && current.Link.
            Element != n)
                current = current.Link;
            return current;
        }

        private Node Find(Object n)
        {
            Node current = new Node();
            current = header.Link;
            while (current.Element != n)
                current = current.Link;
            return current;
        }

        public void Remove(Object n)
        {
            Node p = FindPrevious(n);
            if (!(p.Link == null))
                p.Link = p.Link.Link;
            count--;
        }

        public void Insert(Object n1, n2) 
        {
            Node current = new Node();
            Node newnode = new Node(n1);
            current = Find(n2);
            newnode.Link = current.Link;
            current.Link = newnode;
            count++;
        }

        public void InsertFirst(Object n) 
        {
            Node current = new Node(n);
            current.Link = header;
            header.Link = current;
            count++;
        }

        public Node Move(int n) 
        {
            Node current = header.Link;
            Node temp;
            for(int i = 0; i <= n; i++)
                current = current.Link;
            if (current.Element = "header")
                current = current.Link;
            temp = current;
            return temp;
        }
    }
}

