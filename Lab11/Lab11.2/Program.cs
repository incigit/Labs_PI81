using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._2
{
	class Program
	{
		static readonly int COUNT = 5;

		static void Main()
		{
			Node root = new Node() {Data = "MNTU"};
			root.RightNode = new Node() {Data = "KNIS"};
			root.RightNode.RightNode = new Node() {Data = "Groups"};
			root.RightNode.RightNode.LeftNode = new Node() {Data = "K-71"};
			root.RightNode.RightNode.RightNode = new Node() {Data = "PI-71"};

			print2DUtil(root, 2);
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