﻿using System;

namespace Tree
{
	class Program
	{
		static void Main(string[] args)
		{
			Tree tree = new Tree();

			tree.Add(5);
			tree.Add(4);
			tree.Add(6);
			tree.Add(7);
			tree.Add(3);
			tree.Add(8);
			tree.Add(2);
			tree.Add(9);
			tree.Add(1);
			tree.Add(10);



			tree.Printleft();


			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();


			tree.PrintRight();

			Console.WriteLine();
			Console.WriteLine();


		}
	}
}
