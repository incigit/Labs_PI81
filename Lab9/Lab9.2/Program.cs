using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
	class Program
	{
		static void Main()
		{
			int[] arr = new[] {10, 15, 13, 5, 6, 45, 22, 44, 10, 5, 1, 8, 90, 30, 10, 88, 15, 99, 14, 20};

			int lookup = arr.First();

			int counter = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == lookup) counter++;
			}

			Console.WriteLine($"{counter} entries found for {lookup}.");
			Console.ReadKey();

		}
	}
}