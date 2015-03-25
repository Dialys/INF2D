using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
    public class LinkedList
    {
        protected Node header;
        public LinkedList()
        {
            header = new Node("header");
        }

        private Node Find(Object item)
        {
            Node current = new Node();
            current = header;
            while (current.Element != item)
                current = current.Link;
            return current;
        }

        public void Insert(Object newItem, Object after)
        {
            Node current = new Node();
            Node newNode = new Node(newItem);
            current = Find(after);
            newNode.Link = current.Link;
            current.Link = newNode;
        }

        private Node FindPrevious(Object n)
        {
            Node current = header;
            while (!(current.Link == null) && (current.Link.
            Element != n))
                current = current.Link;
            return current;
        }

        public void Remove(Object n)
        {
            Node p = FindPrevious(n);
            if (!(p.Link == null))
                p.Link = p.Link.Link;
        }

        public void PrintList()
        {
            Node current = new Node();
            current = header;
            while (!(current.Link == null))
            {
                Console.WriteLine(current.Link.Element);
                current = current.Link;
            }
        }
    }
}
