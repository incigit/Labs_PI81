using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
	class Program
	{
		static void Main()
		{
			int[] arrA = new int[50];
			int[] arrB = new int[50];

			InitArray(arrA);
			InitArray(arrB);

			Console.WriteLine("Array A:");
			PrintArr(arrA);
			Console.WriteLine();
			Console.WriteLine("Array B:");
			PrintArr(arrB);
			Console.WriteLine();

			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			SelectionSort(arrA);
			stopwatch.Stop();

			Console.WriteLine($"Array A sorted with selection sort, time elapsed {(double)stopwatch.ElapsedTicks/10000} ms:");
			PrintArr(arrA);
			Console.WriteLine();

			stopwatch.Restart();
			Array.Sort(arrB);
			stopwatch.Stop();
			Console.WriteLine($"Array B sorted with Array.Sort, time elapsed {(double)stopwatch.ElapsedTicks/10000} ms:");
			PrintArr(arrB);
			Console.WriteLine();

			Console.ReadKey();

		}

		static void InitArray(int[] arr)
		{
			Random rand = new Random();
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next() % 499 + 1;
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

		static void SelectionSort(int[] arr)
		{
			int temp, lower;
			for (int i = 0; i < arr.Length - 1; i++)
			{
				lower = i;
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j] < arr[lower])
					{
						lower = j;
					}
				}

				temp = arr[lower];
				arr[lower] = arr[i];
				arr[i] = temp;
			}
		}
	}
}