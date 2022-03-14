// C# program to remove duplicates
// from unsorted linkedlist
using System;
using System.Collections.Generic;

class removeDuplicates {
	class node {
		public int val;
		public node next;

		public node(int val) { this.val = val; }
	}

	// Function to remove duplicates from a
	// unsorted linked list
	static void removeDuplicate(node head)
	{

		// Hash to store seen values
		HashSet<int> hs = new HashSet<int>();

		// Pick elements one by one
		node current = head;
		node prev = null;
		while (current != null) {
			int curval = current.val;

			// If current value is seen before
			if (hs.Contains(curval)) {
				prev.next = current.next;
			}
			else {
				hs.Add(curval);
				prev = current;
			}
			current = current.next;
		}
	}

	// Function to print nodes in a
	// given linked list
	static void printList(node head)
	{
		while (head != null) {
			Console.Write(head.val + " ");
			head = head.next;
		}
	}

	// Driver code
	public static void Main(String[] args)
	{

		// The constructed linked list is:
		// 10->12->11->11->12->11->10
		node start = new node(10);
		start.next = new node(12);
		start.next.next = new node(11);
		start.next.next.next = new node(11);
		start.next.next.next.next = new node(12);
		start.next.next.next.next.next = new node(11);
		start.next.next.next.next.next.next = new node(10);

		Console.WriteLine("Linked list before removing "
						+ "duplicates :");
		printList(start);

		removeDuplicate(start);

		Console.WriteLine("\nLinked list after removing "
						+ "duplicates :");
		printList(start);
	}
}


