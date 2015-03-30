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

        // Constructor
        public LinkedList()
        {
            header = new Node("header"); // Header node
        }

        // Find node method
        private Node Find(Object item)
        {
            Node current = new Node(); // Create node object
            current = header; // Assign current as header node
            while (current.Element != item) // Search for "after" node
                current = current.Link; // Set new node's link field to found node
            return current; // Return found node
        }

        // Insert node method
        public void Insert(Object newItem, Object after)
        {
            Node current = new Node(); // Store current node
            Node newNode = new Node(newItem); // Store new node
            current = Find(after); // after link field
            newNode.Link = current.Link; // Assign new node link field with after node link field
            current.Link = newNode; // Make reference to new node
        }

        // Find node before target method
        private Node FindPrevious(Object n)
        {
            Node current = header; // Start at header
            while (!(current.Link == null) && (current.Link.Element != n)) // Check each node element field until node before target is found
                current = current.Link; // Next node
            return current; // Return target
        }

        // Remove node method
        public void Remove(Object n)
        {
            Node p = FindPrevious(n); // Store node before target
            if (!(p.Link == null)) // If there is a next node
                p.Link = p.Link.Link; // Set link to 2 nodes ahead
        }

        // Print data of each node method
        public void PrintList()
        {
            Node current = new Node();
            current = header; // Start at header
            while (!(current.Link == null)) // As long as there is a next node
            {
                Console.WriteLine(current.Link.Element); // Print current node's data
                current = current.Link; // Next node
            }
        }
    }
}
