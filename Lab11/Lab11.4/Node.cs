using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._4
{
	class Node
	{
		public string Data { get; set; }

		public LinkedList<Node> Children { get; set; }

		public Node()
		{
			Children = new LinkedList<Node>();
		}

		public Node(string data) : this()
		{
			Data = data;
		}

		public void DfsPrint(string indent, bool last)
		{
			Console.Write(indent);
			if (last)
			{
				Console.Write("\\-");
				indent += "  ";
			}
			else
			{
				Console.Write("|-");
				indent += "| ";
			}

			Console.WriteLine(Data);

			for (int i = 0; i < Children.Count; i++)
				Children.ToArray()[i].DfsPrint(indent, i == Children.Count - 1);
		}
	}
}