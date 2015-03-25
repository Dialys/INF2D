using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
    public class Node
    {
        public Object Element; // Node data
        public Node Link; // Next node
        //public Node Flink;
        //public Node Blink;

        // Default Constructor
        public Node()
        {
            Element = null;
            Link = null;
            //Flink = null;
            //Blink = null;
        }

        // Parameterized constructor
        public Node(Object theElement)
        {
            Element = theElement;
            Link = null;
            //Flink = null;
            //Blink = null;
        }
    }
}
