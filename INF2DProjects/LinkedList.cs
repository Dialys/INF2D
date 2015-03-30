using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
    public class LinkedList
    {
        protected LinkedNode header;

        /// Constructor for LinkedList
        public LinkedList()
        {
            header = new LinkedNode("header");
        }

        /// Finds an object in the LinkedList and returns the LinkedNode
        public LinkedNode Find(Object item)
        {
            LinkedNode current = new LinkedNode();
            current = header;

            while (header != item)
            {
                current = current.Link;
            }
            return current;
        }

        /// Gets the first LinkedNode in the list
        public LinkedNode getFirst()
        {
            return header;
        }

        /// Finds the previous LinkedNode and returns this
        private LinkedNode FindPrevious(Object n)
        {
            LinkedNode current = header;
            while (!(current.Link == null) && (current.Link.Element != n))
            {
                current = current.Link;
            }
            return current;
        }

        /// Inserts a new object after the specified object
        public void Insert(Object newItem, Object after)
        {
            LinkedNode current = new LinkedNode();
            LinkedNode newLinkedNode = new LinkedNode(newItem);
            current = Find(after);
            newLinkedNode.Link = current.Link;
            current.Link = newLinkedNode;
        }

        /// Removes an object
        public void Remove(Object n)
        {
            LinkedNode p = FindPrevious(n);
            if (!(p.Link == null))
            {
                p.Link = p.Link.Link;
            }
        }

        /// Prints the LinkedList to Console
        public void PrintList()
        {
            LinkedNode current = new LinkedNode();
            current = header;
            while (!(current.Link == null))
            {
                Console.WriteLine(current.Link.Element);
                current = current.Link;
            }
        }
    }

    public class DoublyLinkedList
    {
        protected DoublyNode header;

        /// Inserts a new object after the specified object
        public void Insert(Object newItem, Object after)
        {
            DoublyNode current = new DoublyNode();
            DoublyNode newNode = new DoublyNode(newItem);
            current = Find(after);
            newNode.Flink = current.Flink;
            newNode.Blink = current;
            current.Flink = newNode;
        }

        /// Finds an object in the DoublyLinkedList and returns the DoublyNode
        private DoublyNode Find(Object item)
        {
            DoublyNode current = new DoublyNode();
            current = header;

            while (header != item)
            {
                current = current.Flink;
            }
            return current;
        }

        /// Removes an object
        public void Remove(Object n)
        {
            DoublyNode p = Find(n);
            if (!(p.Flink == null))
            {
                p.Blink.Flink = p.Flink;
                p.Flink.Blink = p.Blink;
                p.Flink = null;
                p.Blink = null;
            }
        }

        /// Gets the last DoublyNode in the list
        private DoublyNode FindLast()
        {
            DoublyNode current = new DoublyNode();
            current = header;
            while (!(current.Flink == null))
            {
                current = current.Flink;
            }
            return current;
        }

        /// Prints the DoublyLinkedList in reverse to the Console
        /// dsfadgsadgas
        public void PrintReverse()
        {
            DoublyNode current = new DoublyNode();
            current = FindLast();
            while (!(current.Blink == null))
            {
                Console.WriteLine(current.Element);
                current = current.Blink;
            }
        }
    }

    public class CircularlyLinkedList
    {
        protected CircularlyNode current;
        protected CircularlyNode header;
        private int count;

        /// Constructor for CircularlyLinkedList
        public CircularlyLinkedList()
        {
            count = 0;
            header = new CircularlyNode("header");
            header.Flink = header;
        }

        /// Checks whether the list is empty
        public bool isEmpty()
        {
            return (header.Flink == null);
        }

        /// Clears the header
        public void MakeEmpty()
        {
            header.Flink = null;
        }

        /// Prints the list to the Console
        public void PrintList()
        {
            CircularlyNode current = new CircularlyNode();
            current = header;
            while (!(current.Flink.Element.ToString() == "header"))
            {
                Console.WriteLine(current.Flink.Element);
                current = current.Flink;
            }
        }

        /// Finds the previous CircularlyNode and returns this
        private CircularlyNode FindPrevious(Object n)
        {
            CircularlyNode current = header;
            while (!(current.Flink == null) && current.Flink.Element != n)
            {
                current = current.Flink;
            }
            return current;
        }

        /// Finds an object in the list and returns the CircularlyNode
        private CircularlyNode Find(Object n)
        {
            CircularlyNode current = new CircularlyNode();
            current = header.Flink;
            while (current.Element != n)
            {
                current = current.Flink;
            }
            return current;
        }

        /// Removes an object
        public void Remove(Object n)
        {
            CircularlyNode p = FindPrevious(n);
            if(!(p.Flink == null))
            {
                p.Flink = p.Flink.Flink;
            }
            count--;
        }

        /// Inserts the object after the specified object
        public void Insert(Object n1, Object n2)
        {
            CircularlyNode current = new CircularlyNode();
            CircularlyNode newnode = new CircularlyNode(n1);
            current = Find(n2);
            newnode.Flink = current.Flink;
            current.Flink = newnode;
            count++;
        }

        /// Inserts a new CircularlyNode at the first position
        public void InsertFirst(Object n)
        {
            CircularlyNode current = new CircularlyNode(n);
            current.Flink = header;
            header.Flink = current;
            count++;
        }

        /// Moves the CircularlyNode at the specified index
        public CircularlyNode Move(int n)
        {
            CircularlyNode current = header.Flink;
            CircularlyNode temp;
            for (int i = 0; i <= n; i++)
            {
                current = current.Flink;
            }
            if (current.Element.ToString() == "header")
            {
                current = current.Flink;
            }
            temp = current;
            return temp;
        }
    }

    public class LinkedNode
    {
        public Object Element;

        public LinkedNode Link;

        /// Constructor for LinkedNode
        public LinkedNode()
        {
            Element = null;
            Link = null;
        }
        
        /// Constructor for LinkedNode accepting an object
        public LinkedNode(Object theElement)
        {
            Element = theElement;
            Link = null;
        }
    }

    public class DoublyNode
    {
        public Object Element;
        public DoublyNode Flink;
        public DoublyNode Blink;

        /// Constructor for the DoublyNode
        public DoublyNode()
        {
            Element = null;
            Flink = null;
            Blink = null;
        }

        /// Constructor for the DoublyNode accepting an object
        public DoublyNode(Object theElement)
        {
            Element = theElement;
            Flink = null;
            Blink = null;
        }

    }
    public class CircularlyNode
    {
        public Object Element;
        public CircularlyNode Flink;
        public CircularlyNode Blink;

        /// Constructor for the CircularlyNode
        public CircularlyNode()
        {
            Element = null;
            Flink = null;
            Blink = null;
        }

        /// Constructor for the CircularlyNode accepting an object
        public CircularlyNode(Object theElement)
        {
            Element = theElement;
            Flink = null;
            Blink = null;
        }
    }

    public class ListIter
    {
        private LinkedNode current;
        private LinkedNode previous;
        LinkedList theList;

        /// Constructor for the ListIter
        public ListIter(LinkedList list)
        {
            theList = list;
            current = theList.getFirst();
            previous = null;
        }

        /// Moves the iterator to the next link
        public void NextLink()
        {
            previous = current;
            current = current.Link;
        }

        /// Gets the current node
        public LinkedNode GetCurrent()
        {
            return current;
        }

        /// Inserts an object before
        public void InsertBefore(Object theElement)
        {
            LinkedNode newNode = new LinkedNode(theElement);

        }

        /// Inserts an object after
        public void InsertAfter(Object theElement)
        {
            LinkedNode newNode = new LinkedNode(theElement);
            newNode.Link = current.Link;
            current.Link = newNode;
            NextLink();
        }

        /// Removes the current node
        public void Remove()
        {
            previous.Link = current.Link;
        }

        /// Resets the iterator
        public void Reset()
        {
            current = theList.getFirst();
            previous = null;
        }

        /// Checks whether the iterator is at the end of the list
        public bool AtEnd()
        {
            return (current.Link == null);
        }
    }

}
