using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._2
{
	class Program
	{
		static void Main()
		{
			int[] arr100 = new int[100];
			int[] arr500 = new int[500];
			int[] arr1000 = new int[1000];

			InitArray(arr100);
			InitArray(arr500);
			InitArray(arr1000);

			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			QuickSort.Sort(arr100);
			stopwatch.Stop();
			Console.WriteLine($"Array of 100 sorted in {(double) stopwatch.ElapsedTicks / 10000} milliseconds.");

			stopwatch.Restart();
			QuickSort.Sort(arr500);
			stopwatch.Stop();
			Console.WriteLine($"Array of 500 sorted in {(double) stopwatch.ElapsedTicks / 10000} milliseconds.");

			stopwatch.Restart();
			QuickSort.Sort(arr1000);
			stopwatch.Stop();
			Console.WriteLine($"Array of 1000 sorted in {(double)stopwatch.ElapsedTicks / 10000} milliseconds.");

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
	}
}