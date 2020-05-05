using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._2
{
	class Program
	{
		static void Main()
		{
			var set = new HashSet<int>(new List<int>() {0, 2, 4, 7, 2, 1, 10, 0, 0});

			foreach (var i in set)
			{
				Console.Write(i + " ");
			}

			Console.WriteLine();

			set.RemoveWhere(i => (i == 0) || (i == 2));

			foreach (var i in set)
			{
				Console.Write(i + " ");
			}

			Console.ReadKey();
		}
	}
}