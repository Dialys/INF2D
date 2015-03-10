using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2DProjectsDLL
{
	/// <summary>
	///	Custom implementation of a stack datastructure (LIFO structure)
	/// </summary>
    public class CustomStack<T>
    {
		// private fields 
		private int p_index;		// index of the most recent added item
		private List<T> list;		// use ArrayList to store items

		// constructor
		public CustomStack()
		{ 
			// initialise list and index
			list = new List<T>();
			p_index = -1;
		}

		// count the total items
		public int Count
		{
			get
			{
				return list.Count;
			}
		}

		// add new item to the stack
		public void Push(T item)
		{
			list.Add(item);
			p_index++;
		}

		// remove the most recent item
		public T Pop()
		{
			T obj = list[p_index];	// get the most recent item	
			list.RemoveAt(p_index);		// remove the item for the array	
			p_index--;		// decrement most recent index	
			return obj;		// return the deleted object
		}
		
		// empty the stack
		public void Clear()
		{
			list.Clear();
			p_index = -1;	// reset most recent index
		}

		// return the most recent item
		public T Peek()
		{
			return list[p_index];
		}
    }
}
