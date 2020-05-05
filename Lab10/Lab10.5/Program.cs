using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._5
{
	class Program
	{
		static Random Rand = new Random();

		static void Main()
		{
			var listA = new List<int>();
			var listB = new List<int>();
			InitList(listA);
			InitList(listB);
			Console.WriteLine("List A:");
			PrintSet(listA);
			Console.WriteLine("List B:");
			PrintSet(listB);

			var union = listA.Union(listB);
			var intersection = listA.Intersect(listB);
			var subctraction = listA.Except(listB);

			Console.WriteLine("Union:");
			PrintSet(union);
			Console.WriteLine("Insteresction:");
			PrintSet(intersection);
			Console.WriteLine("Substraction:");
			PrintSet(subctraction);

			Console.ReadKey();

		}

		static void InitList(List<int> list)
		{
			
			for (int i = 0; i <= 20; i++)
			{
				list.Add(Rand.Next() % 39 + 11);
			}

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
