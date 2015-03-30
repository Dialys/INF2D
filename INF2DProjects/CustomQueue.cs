using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
	/// <summary>
	///	Generic implementation of the Queue datastructure (FIFO)
	/// </summary>
	public class CustomQueue<T>
	{
		// private fields
		private List<T> cQueue;

		// constructor
		public CustomQueue()
		{
			cQueue = new List<T>();
		}

		// add item to the queue
		public void EnQueue(T item)
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
		public T Peek()
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
