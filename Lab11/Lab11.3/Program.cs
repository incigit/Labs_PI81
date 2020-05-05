using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._3
{
	class Program
	{
		static void Main()
		{
			var catalogue = new LinkedList<Node>();

			catalogue.AddLast(new Node("Computer tech"));
			catalogue.AddLast(new Node("Printers"));

			catalogue.First(node => node.Data == "Computer tech").Children.AddLast(new Node("PC"));
			catalogue.First(node => node.Data == "Computer tech").Children.AddLast(new Node("Laptops"));

			catalogue.First(node => node.Data == "Printers").Children.AddLast(new Node("Laser"));
			catalogue.First(node => node.Data == "Printers").Children.AddLast(new Node("Solid"));

			catalogue.First(node => node.Data == "Printers").Children.First(node => node.Data == "Laser").Children
				.AddLast(new Node("HP Laser"));
			catalogue.First(node => node.Data == "Printers").Children.First(node => node.Data == "Laser").Children
				.AddLast(new Node("Epson Laser"));

			catalogue.First(node => node.Data == "Printers").Children.First(node => node.Data == "Solid").Children
				.AddLast(new Node("HP SolidMaster"));
			catalogue.First(node => node.Data == "Printers").Children.First(node => node.Data == "Solid").Children
				.AddLast(new Node("Epson SolidPrint"));
			catalogue.First(node => node.Data == "Printers").Children.First(node => node.Data == "Solid").Children
				.AddLast(new Node("Asus Solid228"));

			catalogue.First(node => node.Data == "Computer tech").Children.First(node => node.Data == "PC").Children
				.AddLast(new Node("Asus"));
			catalogue.First(node => node.Data == "Computer tech").Children.First(node => node.Data == "PC").Children
				.AddLast(new Node("NZXT"));
			catalogue.First(node => node.Data == "Computer tech").Children.First(node => node.Data == "PC").Children
				.AddLast(new Node("Corsair"));

			catalogue.First(node => node.Data == "Computer tech").Children.First(node => node.Data == "Laptops")
				.Children
				.AddLast(new Node("Acer"));
			catalogue.First(node => node.Data == "Computer tech").Children.First(node => node.Data == "Laptops")
				.Children
				.AddLast(new Node("Lenovo"));


			foreach (var node in catalogue)
			{
				node.DfsPrint("", true);
			}

			Console.ReadKey();
		}
	}
}