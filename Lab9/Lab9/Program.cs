using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
	class Program
	{
		static void Main()
		{
			int[] arr = new int[100];
			InitArray(arr);

			Console.WriteLine("Enter the value to search for (from 0 to 100):");
			int lookupValue = int.Parse(Console.ReadLine());
			int index = LinearSearch(arr, lookupValue);

			if (index == -1)
			{
				Console.WriteLine("Value doesn't exist in the array.");
			}
			else
			{
				int lastIndex = LinearSearchLast(arr, lookupValue);
				if (index == lastIndex)
				{
					Console.WriteLine($"Only one entry found, the first and last index is {index}.");
				}
				else
				{
					Console.WriteLine($"First entry is at {index} index.");
					Console.WriteLine($"Last entry is at {lastIndex} index.");
				}
			}



			Console.ReadKey();
		}

		static int LinearSearch(int[] arr, int lookup)
		{
			for (int i = 0; i < arr.Length; i++)
				if (arr[i] == lookup)
					return i;
			return -1;
		}

		static int LinearSearchLast(int[] arr, int lookup)
		{
			int last = -1;
			for (int i = 0; i < arr.Length; i++)
				if (arr[i] == lookup)
					last = i;
			return last;
		}

		static void InitArray(int[] arr)
		{
			Random rand = new Random();
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next() % 99 + 1;
			}
		}
	}
}