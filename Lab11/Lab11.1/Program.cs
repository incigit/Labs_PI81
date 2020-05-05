using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._1
{
	class Program
	{
		static readonly int COUNT = 5;

		static void Main()
		{
			var tree = new List<Node>(new List<Node>()
			{
				new Node() {Data = "F"}, new Node() {Data = "G"}, new Node() {Data = "I"}, new Node() {Data = "H"},
				new Node() {Data = "B"}, new Node() {Data = "A"}, new Node() {Data = "B"}, new Node() {Data = "D"},
				new Node() {Data = "C"}, new Node() {Data = "E"}
			});
			tree.Find(node => node.Data == "F").LeftNode = tree.Find(node => node.Data == "B");
			tree.Find(node => node.Data == "F").RightNode = tree.Find(node => node.Data == "G");
			tree.Find(node => node.Data == "B").LeftNode = tree.Find(node => node.Data == "A");
			tree.Find(node => node.Data == "B").RightNode = tree.Find(node => node.Data == "D");
			tree.Find(node => node.Data == "D").LeftNode = tree.Find(node => node.Data == "C");
			tree.Find(node => node.Data == "D").RightNode = tree.Find(node => node.Data == "E");
			tree.Find(node => node.Data == "G").RightNode = tree.Find(node => node.Data == "I");
			tree.Find(node => node.Data == "I").LeftNode = tree.Find(node => node.Data == "H");

			// Adding Node K to Node I
			tree.Find(node => node.Data == "I").RightNode = new Node() {Data = "K"};

			print2DUtil(tree.Find(node => node.Data == "F"), 0);
			Console.ReadKey();

		}

		static void print2DUtil(Node root, int space)
		{
			// Base case  
			if (root == null)
				return;

			// Increase distance between levels  
			space += COUNT;

			// Process right child first  
			print2DUtil(root.RightNode, space);

			// Print current node after space  
			// count  
			Console.Write("\n");
			for (int i = COUNT; i < space; i++)
				Console.Write(" ");
			Console.Write(root.Data + "\n");

			// Process left child  
			print2DUtil(root.LeftNode, space);
		}

		// Wrapper over print2DUtil()  
		static void print2D(Node root)
		{
			// Pass initial space count as 0  
			print2DUtil(root, 0);
		}
	}
}