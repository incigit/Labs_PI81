﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._3
{
	class QuickSort
	{
		public static void Sort(int[] arr)
		{
			Sort(arr, 0, arr.Length - 1);
		}

		private static void Sort(int[] arr, int left, int right)
		{
			if (left < right)
			{
				int pivot = Partition(arr, left, right);

				if (pivot > 1)
				{
					Sort(arr, left, pivot - 1);
				}

				if (pivot + 1 < right)
				{
					Sort(arr, pivot + 1, right);
				}
			}
		}

		private static int Partition(int[] arr, int left, int right)
		{
			int pivot = arr[left];
			while (true)
			{
				while (arr[left] < pivot)
				{
					left++;
				}

				while (arr[right] > pivot)
				{
					right--;
				}

				if (left < right)
				{
					if (arr[left] == arr[right]) return right;

					int temp = arr[left];
					arr[left] = arr[right];
					arr[right] = temp;
				}
				else
				{
					return right;
				}
			}
		}
	}
}