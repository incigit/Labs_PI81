using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._1
{
	class Program
	{
		static void Main()
		{
			var m1 = new HashSet<int>(new List<int>() {1, 4, 6, 9});
			var m2 = new HashSet<int>(new List<int>() {4, 9, 0, 10, 11});

			Console.WriteLine("m1 set:");
			PrintSet(m1);
			Console.WriteLine("m2 set:");
			PrintSet(m2);			

			Console.WriteLine("Union:");
			var union = new HashSet<int>(m1);
			union.UnionWith(m2);
			PrintSet(union);

			Console.WriteLine("Intersection:");
			var intersection = new HashSet<int>(m1);
			intersection.IntersectWith(m2);
			PrintSet(intersection);

			Console.WriteLine("Substraction m1-m2:");
			var substraction = new HashSet<int>(m1.ToArray());
			substraction.ExceptWith(m2);
			PrintSet(substraction);

			Console.WriteLine("Symmetrical substraction:");
			var symmetricalSubtraction = new HashSet<int>(m1);
			symmetricalSubtraction.SymmetricExceptWith(m2);
			PrintSet(symmetricalSubtraction);

			Console.ReadKey();
		}

		static void PrintSet(IEnumerable<int> set)
		{
			foreach (var i in set)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}
	}
}