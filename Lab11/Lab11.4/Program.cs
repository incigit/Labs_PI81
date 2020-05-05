using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._4
{
	class Program
	{
		static void Main()
		{
			var structure = new LinkedList<Node>();

			structure.AddLast(new Node("Solution"));
			structure.First(node => node.Data == "Solution").Children.AddLast(new Node("ProjectA"));
			structure.First(node => node.Data == "Solution").Children.AddLast(new Node("ProjectB"));

			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectA").Children
				.AddLast(new Node("Properties"));
			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectA").Children
				.First(node => node.Data == "Properties").Children.AddLast(new Node("AssemblyInfo.cs"));
			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectA")
				.Children.AddLast(new Node("App.config"));
			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectA")
				.Children.AddLast(new Node("Program.cs"));
			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectA")
				.Children.AddLast(new Node("MyClass.cs"));

			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectB").Children
				.AddLast(new Node("Properties"));
			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectB").Children
				.First(node => node.Data == "Properties").Children.AddLast(new Node("AssemblyInfo.cs"));
			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectB")
				.Children.AddLast(new Node("App.config"));
			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectB")
				.Children.AddLast(new Node("Program.cs"));
			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectB")
				.Children.AddLast(new Node("Class1.cs"));
			structure.First(node => node.Data == "Solution").Children.First(node => node.Data == "ProjectB")
				.Children.AddLast(new Node("Class2.cs"));

			structure.First().DfsPrint("", true);
			Console.ReadKey();

		}
	}
}
