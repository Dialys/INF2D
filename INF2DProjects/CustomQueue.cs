using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
	public class CustomQueue
	{
		// private fields
		private ArrayList cQueue;

		// constructor
		public CustomQueue()
		{
			cQueue = new ArrayList();
		}

		// add item to the queue
		public void EnQueue(Object item)
		{
			cQueue.Add(item);
		}

		// remove the first item from the queue
		public void DeQueue()
		{
			// index zero for first item
			cQueue.RemoveAt(0);
		}

		// view the first item in the queue
		public Object Peek()
		{
			// index zero for first item
			return cQueue[0];
		}

		// empty the queue
		public void ClearQueue()
		{
			cQueue.Clear();
		}
	}
}
