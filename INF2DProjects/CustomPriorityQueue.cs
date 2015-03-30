using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
	/// <summary>
	/// The value type for the CustomPriorityQueue
	/// It holds a name and a priority
	/// </summary>
	public struct pqItem
	{
		public string name { get; set; }
		public int priority { get; set; }
	}

	/// <summary>
	/// Custom priority queue extends the queue class
	/// The only allowed element inside the CustomPriorityQueue is the pqItem
	/// </summary>
	public class CustomPriorityQueue : Queue
	{
		public CustomPriorityQueue()
			: base()
		{
			// load Queue constructor
		}

		// override Dequeue method to remove item with lowest priority
		public override object Dequeue()
		{
			object[] items;
			int min, minindex;
			// convert the existing queue to an array
			items = this.ToArray();
			// set the first item as starting value
			min = ((pqItem)items[0]).priority;
			minindex = 0;
			// loop over items
			// starting from index position one
			for (int x = 1; x <= items.GetUpperBound(0); x++)
			{
				// check if the current item's priority is lower than minimum
				if (((pqItem)items[x]).priority < min)
				{
					// set current item as minimum and save the index
					min = ((pqItem)items[x]).priority;
					minindex = x;
				}
			}
			// clear the queue
			this.Clear();
			// rebuild the base queue
			for (int x = 0; x <= items.GetUpperBound(0); x++)
			{
				// add all remaining the items to the queue
				// without the one with the lowest priority
				if (x != minindex && ((pqItem)items[x]).name != "")
				{
					this.Enqueue(items[x]);
				}
			}
			// return the item with the lowest priority
			return items[minindex];
		}
	}
}
