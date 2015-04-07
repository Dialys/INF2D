using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2DProjectsDLL;

namespace testHarrie
{
	class Program
	{
		static void Main(string[] args)
		{
			// create some test data for the stack and the queue
			string[] text = new string[3];
			text[0] = "De eerste string";
			text[1] = "De tweede string";
			text[2] = "De derde string";

			#region CustomStack test

			Console.WriteLine("CustomStack test (LIFO)");
			// create a stack of the type string
			CustomStack<string> stack = new CustomStack<string>();
			// add the strings to the stack
			for (int i = 0; i <= text.GetUpperBound(0); i++)
			{
				stack.Push(text[i]);
			}

			// remove and show the order of removed items
			for (int i = 0; i <= text.GetUpperBound(0); i++)
			{
				Console.WriteLine("- " + stack.Pop());
			}

			#endregion

			Console.WriteLine();

			#region CustomQueue test

			Console.WriteLine("CustomQueue test (FIFO)");
			// create a generic questom queue
			CustomQueue<string> queue = new CustomQueue<string>();
			// add items to the queue
			for (int i = 0; i <= text.GetUpperBound(0); i++)
			{
				queue.EnQueue(text[i]);
			}

			// remove the items and show the position
			for (int i = 0; i <= text.GetUpperBound(0); i++)
			{
				Console.WriteLine("- " + queue.Peek());
				queue.DeQueue();
			}

			#endregion

			Console.WriteLine();

			#region CustomPriorityQueue test

			Console.WriteLine("CustomPriorityQueue");
			// create a CustomPriorityQueue to simulate a waiting room for patients
			// where priority 0 is first
			CustomPriorityQueue waitingRoom = new CustomPriorityQueue();
			pqItem[] patients = new pqItem[4];
			patients[0].name = "Klaas";
			patients[0].priority = 1;
			patients[1].name = "Gerald";
			patients[1].priority = 3;
			patients[2].name = "Tessa";
			patients[2].priority = 0;
			patients[3].name = "Yvonne";
			patients[3].priority = 7;
			// add all patients to the priority queue
			for (int i = 0; i <= patients.GetUpperBound(0); i++)
			{
				waitingRoom.Enqueue(patients[i]);
			}

			// remove patients from waiting list in order of their priority
			for (int i = 0; i <= patients.GetUpperBound(0); i++)
			{
				pqItem patient = (pqItem)waitingRoom.Dequeue();
				Console.WriteLine(patient.priority + ": " + patient.name);
			}

			#endregion

			Console.ReadKey();
		}
	}
}
