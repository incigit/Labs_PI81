using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._3
{
	class Program
	{
		static void Main()
		{
			var positiveSet = new SortedSet<int>(new List<int>() {2, 10, 15, 7, 9, 74, 33, 22, 11, 17, 0});
			var negativeSet = new SortedSet<int>(new List<int>() {-40, -10, -13, -7, -9, -4, -35, -12, -46, -27, 0});

			var union = new SortedSet<int>(positiveSet);
			union.UnionWith(negativeSet);
			Console.WriteLine("Union:");
			foreach (var i in union)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();

			var intersect = new SortedSet<int>(positiveSet);
			intersect.IntersectWith(negativeSet);
			Console.WriteLine("Intersection:");
			foreach (var i in intersect)
			{
				Console.Write(i + " ");
			}

			Console.WriteLine();
			Console.ReadKey();

		}
	}
}