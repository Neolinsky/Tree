using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
	/// <summary>
	/// Tree contains value of integers
	/// </summary>
	class Tree
	{
		public element root;


		public void add(int value,  element node)
		{
			
			if (node != null)
			{
				if(value > node.value)
				{
					if(node.right != null)
					{
						node = node.right;
						add(value, node);
					}
					else
					{
						node.right = new element(value);
						element.count++;
						return;
					}			
				}

				if(value < node.value)
				{
					if (node.left != null)
					{
						node = node.left;
						add(value, node);
					}
					else
					{
						node.left = new element(value);
						element.count++;
						return;
					}
				}		
			}
		}

		public void Add(int value)
		{
			if (root == null)
			{
				root = new element(value);
			}
			else
			{
				add(value, root);
			}
		}

		public void  Printleft()
		{
			element Root = root;
			while(Root != null)
			{
				Console.WriteLine(Root.value);
				Root = Root.left;
			}
		}

		public void PrintRight()
		{
			element Root = root;
			while (Root != null)
			{
				Console.WriteLine(Root.value);
				Root = Root.right;
			}
		}


		

	}
}
