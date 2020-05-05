using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._3
{
	class Program
	{
		static void Main()
		{
			int[] arr = new int[100];
			InitArray(arr);
			Console.WriteLine("Inittial array:");
			PrintArr(arr);

			QuickSort.Sort(arr);
			Console.WriteLine("Sorted array:");
			PrintArr(arr);

			Console.WriteLine("Enter lookup value:");
			int lookup = int.Parse(Console.ReadLine());
			int index = BinarySearch(arr, lookup);
			if (index == -1)
			{
				Console.WriteLine("Element not found.");
			}
			else
			{
				Console.WriteLine($"Element found at {index} index.");
			}

			Console.ReadKey();
		}

		static void InitArray(int[] arr)
		{
			Random rand = new Random();
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next() % 999 + 1;
			}
		}

		static void PrintArr(int[] arr)
		{
			foreach (int t in arr)
			{
				Console.Write(t + " ");
			}

			Console.Write(Environment.NewLine);
		}

		static int BinarySearch(int[] arr, int lookup)
		{
			int minNum = 0;
			int maxNum = arr.Length - 1;

			while (minNum <= maxNum)
			{
				int mid = (minNum + maxNum) / 2;
				if (lookup == arr[mid])
				{
					return ++mid;
				}

				if (lookup < arr[mid])
				{
					maxNum = mid - 1;
				}
				else
				{
					minNum = mid + 1;
				}
			}

			return -1;
		}
	}
}