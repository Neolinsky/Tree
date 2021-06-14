using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
	/// <summary>
	/// Element of a tree.
	/// </summary>
	class element
	{
		// Stares adress of prev element
		public element prev;

		// Stares adress of left element
		public element left;

		// Stares adress of right element
		public element right;

		public int value;
		public static int count;


		public element()
		{

		}

		public element(int value)
		{
			this.value = value;
		}

	}
}
